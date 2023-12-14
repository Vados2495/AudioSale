using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
