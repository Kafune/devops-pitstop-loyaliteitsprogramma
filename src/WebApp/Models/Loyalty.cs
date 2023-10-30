namespace Pitstop.WebApp.Models;

public class Loyalty
{
        [Required]
        [Display(Name = "Customer ID")]
        public string CustomerID { get; set; }
    [Display(Name = "Points")]
    public string Points { get; set; }
    [Display(Name = "Category")]
    public string Category { get; set; }

}