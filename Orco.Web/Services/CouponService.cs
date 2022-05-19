using Orco.Web.Models;
using Orco.Web.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace Orco.Web.Services
{
    public class CouponService : BaseService, ICouponService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CouponService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> GetCoupon<T>(string couponCode, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.APIType.GET,
                Url = SD.CouponAPIBase + $"api/coupon/{couponCode}",
                AccessToken = token
            });
        }
    }
}
