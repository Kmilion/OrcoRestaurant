using Orco.Web.Models.DTOs;
using System.Threading.Tasks;

namespace Orco.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<T> GetCoupon<T>(string couponCode, string token = null);
    }
}
