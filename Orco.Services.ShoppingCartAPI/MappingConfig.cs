using AutoMapper;
using Orco.Services.ShoppingCartAPI.Models;
using Orco.Services.ShoppingCartAPI.Models.DTOs;

namespace Orco.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductDTO>().ReverseMap();
                config.CreateMap<CartHeader, CartHeaderDTO>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDTO>().ReverseMap();
                config.CreateMap<Cart, CartDTO>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
