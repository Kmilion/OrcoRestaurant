namespace Orco.Services.ProductAPI.Models.Response
{
    public class ProductResponse
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string ImageUrl { get; set; }
    }
}
