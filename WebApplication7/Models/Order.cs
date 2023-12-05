using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public int UserID { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public string Status { get; set; } = string.Empty;
    }
}
