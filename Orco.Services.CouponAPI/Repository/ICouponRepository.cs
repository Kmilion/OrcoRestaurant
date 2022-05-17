using Orco.Services.CouponAPI.Models.DTOs;
using System.Threading.Tasks;

namespace Orco.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDTO> GetCouponByCode(string couponCode);
    }
}
