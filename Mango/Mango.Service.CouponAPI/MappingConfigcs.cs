using AutoMapper;
using Mango.Service.CouponAPI.Models;
using Mango.Service.CouponAPI.Models.Dto;
namespace Mango.Service.CouponAPI
{
    public class MappingConfigcs
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config=>
            {
                config.CreateMap<CouponsDTO, Coupons>();
                config.CreateMap<Coupons, CouponsDTO>();
            });
            return mappingConfig;
        }
    }
}
