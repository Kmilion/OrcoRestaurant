using AutoMapper;
using Orco.Services.CouponAPI.Models;
using Orco.Services.CouponAPI.Models.DTOs;

namespace Orco.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon, CouponDTO>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
