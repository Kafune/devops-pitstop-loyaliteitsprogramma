namespace Pitstop.WebApp.Models
{

    public class LoyaltyCombined
    {
        [Required]
        [Display(Name = "CustomerId")]
        public int CustomerId { get; set; }

        [Display(Name = "CustomerName")]
        public string CustomerName { get; set; }

        [Display(Name = "Points")]
        public int Points { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }
    }
}
