using Orco.Services.OrderAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orco.Services.OrderAPI.Messages
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string ImageUrl { get; set; }
    }
}
