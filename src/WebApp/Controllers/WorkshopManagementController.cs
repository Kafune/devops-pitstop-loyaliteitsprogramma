using Pitstop.WebApp.RESTClients;

namespace PitStop.WebApp.Controllers;

    public class WorkshopManagementController : Controller
{
    private IWorkshopManagementAPI _workshopManagementAPI;
    private readonly ILoyaltySystemAPI _loyaltySystemAPI;
    private readonly Microsoft.Extensions.Logging.ILogger _logger;
    private ResiliencyHelper _resiliencyHelper;

    public WorkshopManagementController(IWorkshopManagementAPI workshopManagamentAPI, ILogger<WorkshopManagementController> logger, ILoyaltySystemAPI loyaltySystemAPI)
    {
        _workshopManagementAPI = workshopManagamentAPI;
        _logger = logger;
        _resiliencyHelper = new ResiliencyHelper(_logger);
        _loyaltySystemAPI = loyaltySystemAPI;
    }

    [HttpGet]
    public async Task<IActionResult> Index(DateTime? planningDate)
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            if (planningDate == null)
            {
                planningDate = DateTime.Now.Date;
            }

            var model = new WorkshopManagementViewModel
            {
                Date = planningDate.Value,
                MaintenanceJobs = new List<MaintenanceJob>()
            };

                // get planning
                string dateStr = planningDate.Value.ToString("yyyy-MM-dd");
            WorkshopPlanning planning = await _workshopManagementAPI.GetWorkshopPlanning(dateStr);
            if (planning?.Jobs?.Count > 0)
            {
                model.MaintenanceJobs.AddRange(planning.Jobs.OrderBy(j => j.StartTime));
            }

            return View(model);
        }, View("Offline", new WorkshopManagementOfflineViewModel()));
    }

    [HttpGet]
    public async Task<IActionResult> Details(DateTime planningDate, string jobId)
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            string dateStr = planningDate.ToString("yyyy-MM-dd");
            var model = new WorkshopManagementDetailsViewModel
            {
                Date = planningDate,
                MaintenanceJob = await _workshopManagementAPI.GetMaintenanceJob(dateStr, jobId)
            };
            return View(model);
        }, View("Offline", new WorkshopManagementOfflineViewModel()));
    }

    [HttpGet]
    public async Task<IActionResult> New(DateTime planningDate)
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            DateTime startTime = planningDate.Date.AddHours(8);

            var model = new WorkshopManagementNewViewModel
            {
                Id = Guid.NewGuid(),
                Date = planningDate,
                StartTime = startTime,
                EndTime = startTime.AddHours(2),
                Vehicles = await GetAvailableVehiclesList()
            };
            return View(model);
        }, View("Offline", new WorkshopManagementOfflineViewModel()));
    }

    [HttpGet]
    public async Task<IActionResult> Finish(DateTime planningDate, string jobId)
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            string dateStr = planningDate.ToString("yyyy-MM-dd");
            MaintenanceJob job = await _workshopManagementAPI.GetMaintenanceJob(dateStr, jobId);

            int loyaltyPointsEarned = (int)Math.Floor((job.EndTime - job.StartTime).TotalMinutes / 30) * 25;

            var model = new WorkshopManagementFinishViewModel
            {
                Id = job.Id,
                Date = planningDate,
                ActualStartTime = job.StartTime,
                ActualEndTime = job.EndTime,
            };
            var loyaltyModel = new LoyaltyManagementViewModel
            {
                CustomerId = job.Customer.CustomerId,
                SelectedVehicleLicenseNumber = job.Vehicle.LicenseNumber,
                LoyaltyPoints = loyaltyPointsEarned
            };
            var loyaltyWorkshopVM= new LoyaltyWorkshopViewmodel
            {
                WorkshopManagementFinishViewModel = model,
                LoyaltyManagementViewModel = loyaltyModel
            };
            return View(loyaltyWorkshopVM);
        }, View("Offline", new WorkshopManagementOfflineViewModel()));
    }

    [HttpPost]
    public async Task<IActionResult> RegisterMaintenanceJob([FromForm] WorkshopManagementNewViewModel inputModel)
    {
        if (ModelState.IsValid)
        {
            return await _resiliencyHelper.ExecuteResilient(async () =>
            {
                string dateStr = inputModel.Date.ToString("yyyy-MM-dd");

                try
                {
                    // register maintenance job
                    DateTime startTime = inputModel.Date.Add(inputModel.StartTime.TimeOfDay);
                    DateTime endTime = inputModel.Date.Add(inputModel.EndTime.TimeOfDay);
                    Vehicle vehicle = await _workshopManagementAPI.GetVehicleByLicenseNumber(inputModel.SelectedVehicleLicenseNumber);
                    Customer customer = await _workshopManagementAPI.GetCustomerById(vehicle.OwnerId);

                    PlanMaintenanceJob planMaintenanceJobCommand = new PlanMaintenanceJob(Guid.NewGuid(), Guid.NewGuid(), startTime, endTime,
                        (customer.CustomerId, customer.Name, customer.TelephoneNumber),
                        (vehicle.LicenseNumber, vehicle.Brand, vehicle.Type), inputModel.Description);
                    await _workshopManagementAPI.PlanMaintenanceJob(dateStr, planMaintenanceJobCommand);
                }
                catch (ApiException ex)
                {
                    if (ex.StatusCode == HttpStatusCode.Conflict)
                    {
                            // add errormessage from API exception to model
                            var content = await ex.GetContentAsAsync<BusinessRuleViolation>();
                        inputModel.Error = content.ErrorMessage;

                            // repopulate list of available vehicles in the model
                            inputModel.Vehicles = await GetAvailableVehiclesList();

                            // back to New view
                            return View("New", inputModel);
                    }
                }

                return RedirectToAction("Index", new { planningDate = dateStr });
            }, View("Offline", new WorkshopManagementOfflineViewModel()));
        }
        else
        {
            inputModel.Vehicles = await GetAvailableVehiclesList();
            return View("New", inputModel);
        }
    }

    [HttpPost]
    public async Task<IActionResult> FinishMaintenanceJob([FromForm] LoyaltyWorkshopViewmodel inputModel)
    {
        if (ModelState.IsValid)
        {
            WorkshopManagementFinishViewModel workshopVM = inputModel.WorkshopManagementFinishViewModel;
            LoyaltyManagementViewModel loyaltyVM = inputModel.LoyaltyManagementViewModel;
            return await _resiliencyHelper.ExecuteResilient(async () =>
            {
                string dateStr = workshopVM.Date.ToString("yyyy-MM-dd");
                DateTime actualStartTime = workshopVM.Date.Add(workshopVM.ActualStartTime.Value.TimeOfDay);
                DateTime actualEndTime = workshopVM.Date.Add(workshopVM.ActualEndTime.Value.TimeOfDay);

                // calculate loyalty points based on actual duration of maintenance job. give 25 loyalty points for every 30 minutes of maintenance.
                int loyaltyPointsEarned = (int)Math.Floor((actualEndTime - actualStartTime).TotalMinutes / 30) * 25;

                loyaltyVM.LoyaltyPoints = loyaltyPointsEarned;

                FinishMaintenanceJob cmd = new FinishMaintenanceJob(Guid.NewGuid(), workshopVM.Id,
                    actualStartTime, actualEndTime, workshopVM.Notes, loyaltyVM.LoyaltyPoints);

                AddLoyaltyPoints addLoyaltyCmd = new(Guid.NewGuid(), loyaltyVM.CustomerId, loyaltyVM.LoyaltyPoints);
                AddLoyaltyPointsRequest addLoyaltyPointsRequest = new() { 
                    CustomerId = loyaltyVM.CustomerId,
                    LoyaltyPoints = loyaltyVM.LoyaltyPoints
                };

                Console.WriteLine(loyaltyVM.CustomerId);

                await _workshopManagementAPI.FinishMaintenanceJob(dateStr, workshopVM.Id.ToString("D"), cmd);

                await _loyaltySystemAPI.AddLoyaltyPoints(addLoyaltyPointsRequest, addLoyaltyCmd);

                return RedirectToAction("Details", new { planningDate = dateStr, jobId = workshopVM.Id });
            }, View("Offline", new WorkshopManagementOfflineViewModel()));
        }
        else
        {
            return View("Finish", inputModel.WorkshopManagementFinishViewModel);
        }
    }

    public IActionResult Error()
    {
        return View();
    }

    private async Task<IEnumerable<SelectListItem>> GetAvailableVehiclesList()
    {
        var vehicles = await _workshopManagementAPI.GetVehicles();
        return vehicles.Select(v =>
            new SelectListItem
            {
                Value = v.LicenseNumber,
                Text = $"{v.Brand} {v.Type} [{v.LicenseNumber}]"
            });
    }
}