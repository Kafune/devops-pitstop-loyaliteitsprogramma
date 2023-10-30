using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoyaltySystemAPI.Models
{
    public class Loyalty
    {
        public string CustomerID { get; set; }
        public string Points { get; set; }
        public string Category { get; set; }

    }
}
