using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Service
{
    public class CouponService(BaseService baseService) : ICouponService
    {
        BaseService _baseService = baseService;

        public async Task<ResponseDto?> CreateCoupnsAsync(CouponsDTO couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.POST,
                Data = couponDto,
                Url = Utility.SD.CouponAPIBase + "/api/coupon/",
            });
        }

        public async Task<ResponseDto?> DeleteCoupnsAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.DELETE,
                Url = Utility.SD.CouponAPIBase + "/api/coupon/" + Convert.ToString(id),
            });
        }

        public async Task<ResponseDto?> GetAllCoupnsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = Utility.SD.CouponAPIBase+"/api/coupon",
            });
        }

        public async Task<ResponseDto?> GetAllCoupnsByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = Utility.SD.CouponAPIBase + "/api/coupon/" + Convert.ToString(id),
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.GET,
                Url = Utility.SD.CouponAPIBase + "/api/coupon/GetbyCode/" + couponCode,
            });
        }

        public async Task<ResponseDto?> UpdateCoupnsAsync(CouponsDTO couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = ApiType.PUT,
                Data = couponDto,
                Url = Utility.SD.CouponAPIBase + "/api/coupon/",
            });
        }
    }
}
