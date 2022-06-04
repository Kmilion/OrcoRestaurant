using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Orco.Services.CouponAPI.Context;
using Orco.Services.CouponAPI.Models.DTOs;
using System.Linq;
using System.Threading.Tasks;

namespace Orco.Services.CouponAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public CouponRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CouponDTO> GetCouponByCode(string couponCode)
        {
            var couponFromDb = await _db.Coupons.FirstOrDefaultAsync(u => u.CouponCode == couponCode);

            return _mapper.Map<CouponDTO>(couponFromDb);
        }
    }
}
