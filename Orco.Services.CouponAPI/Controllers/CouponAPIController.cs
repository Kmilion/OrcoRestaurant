using Microsoft.AspNetCore.Mvc;
using Orco.Services.CouponAPI.Models.DTOs;
using Orco.Services.CouponAPI.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orco.Services.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/coupon")]
    public class CouponAPIController : Controller
    {
        private readonly ICouponRepository _couponRepository;
        protected ResponseDTO _response;

        public CouponAPIController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
            _response = new ResponseDTO();
        }

        [HttpGet("{couponCode}")]
        public async Task<object> GetDiscountForCode(string couponCode)
        {
            try
            {
                CouponDTO couponDTO = await _couponRepository.GetCouponByCode(couponCode);
                _response.Result = couponDTO;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
