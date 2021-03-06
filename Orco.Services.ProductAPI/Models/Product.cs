using System.ComponentModel.DataAnnotations;

namespace Orco.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string ImageUrl { get; set; }
    }
}
