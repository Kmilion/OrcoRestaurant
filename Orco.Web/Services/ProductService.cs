using Orco.Web.Models;
using Orco.Web.Models.DTOs;
using Orco.Web.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace Orco.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDTO productDTO, string token)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.POST,
                Data = productDTO,
                Url = SD.ProductAPIBase + "api/products",
                AccessToken = token
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id, string token)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.DELETE,
                Url = SD.ProductAPIBase + $"api/products/{id}",
                AccessToken = token
            });
        }

        public async Task<T> GetAllProductsAsync<T>(string token)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.GET,
                Url = SD.ProductAPIBase + "api/products",
                AccessToken = token
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id, string token)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.GET,
                Url = SD.ProductAPIBase + $"api/products/{id}",
                AccessToken = token
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDTO productDTO, string token)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.PUT,
                Data = productDTO,
                Url = SD.ProductAPIBase + "api/products",
                AccessToken = token
            });
        }
    }
}
