using System.ComponentModel.DataAnnotations;

namespace Orco.Web.Models.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Precio")]
        public double Price { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Categoría")]
        public ProductCategory ProductCategory { get; set; }
        [Display(Name = "Ruta de imagen")]
        public string ImageUrl { get; set; }
    }
}
