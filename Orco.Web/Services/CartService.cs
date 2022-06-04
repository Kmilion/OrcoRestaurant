using Orco.Web.Models;
using Orco.Web.Models.DTOs;
using Orco.Web.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace Orco.Web.Services
{
    public class CartService : BaseService, ICartService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CartService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> AddToCartAsync<T>(CartDTO cartDTO, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.POST,
                Data = cartDTO,
                Url = SD.ShoppingCartAPIBase + "api/cart/AddCart",
                AccessToken = token
            });
        }

        public async Task<T> ApplyCoupon<T>(CartDTO cartDTO, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.POST,
                Data = cartDTO,
                Url = SD.ShoppingCartAPIBase + "api/cart/ApplyCoupon",
                AccessToken = token
            });
        }

        public async Task<T> GetCartByUserIdAsync<T>(string userId, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.GET,
                Url = SD.ShoppingCartAPIBase + $"api/cart/GetCart/{userId}",
                AccessToken = token
            });
        }

        public async Task<T> RemoveCoupon<T>(string userId, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.POST,
                Data = userId,
                Url = SD.ShoppingCartAPIBase + "api/cart/RemoveCoupon",
                AccessToken = token
            });
        }

        public async Task<T> RemoveFromCartAsync<T>(int cartId, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.POST,
                Data = cartId,
                Url = SD.ShoppingCartAPIBase + "api/cart/RemoveCart",
                AccessToken = token
            });
        }

        public async Task<T> UpdateCartAsync<T>(CartDTO cartDTO, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.POST,
                Data = cartDTO,
                Url = SD.ShoppingCartAPIBase + "api/cart/UpdateCart",
                AccessToken = token
            });
        }
    }
}
