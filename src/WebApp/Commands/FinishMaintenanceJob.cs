namespace Pitstop.WebApp.Commands;

public class FinishMaintenanceJob : Command
{
    public readonly Guid JobId;
    public readonly DateTime StartTime;
    public readonly DateTime EndTime;
    public readonly string Notes;
    public readonly int LoyaltyPointsEarned;

    public FinishMaintenanceJob(Guid messageId, Guid jobId, DateTime startTime, DateTime endTime, string notes, int loyaltyPointsEarned) :
        base(messageId)
    {
        JobId = jobId;
        StartTime = startTime;
        EndTime = endTime;
        Notes = notes;
        LoyaltyPointsEarned = loyaltyPointsEarned;
    }
}