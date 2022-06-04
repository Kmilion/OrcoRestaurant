using Newtonsoft.Json;
using Orco.Services.ShoppingCartAPI.Models.DTOs;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Orco.Services.ShoppingCartAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly HttpClient client;
        public CouponRepository(HttpClient client)
        {
            this.client = client;
        }

        public async Task<CouponDTO> GetCoupon(string couponName)
        {
            var response = await client.GetAsync($"api/coupon/{couponName}");
            var apiContent = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDTO>(apiContent);

            if (resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<CouponDTO>(Convert.ToString(resp.Result));
            }
            return new CouponDTO();
        }
    }
}
