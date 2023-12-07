using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
