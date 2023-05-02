using System.ComponentModel.DataAnnotations;

namespace Shared_Layer
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required]
        public string Category { get; set; } = string.Empty;
        [Required]
        public int Price { get; set; }
        [Required]
        public int Discount { get; set; }
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        public string Warranty { get; set; } = string.Empty;


    }
}