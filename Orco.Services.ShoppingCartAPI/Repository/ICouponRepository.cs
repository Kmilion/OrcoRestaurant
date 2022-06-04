using Orco.Services.ShoppingCartAPI.Models.DTOs;
using System.Threading.Tasks;

namespace Orco.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDTO> GetCoupon(string couponName);
    }
}
