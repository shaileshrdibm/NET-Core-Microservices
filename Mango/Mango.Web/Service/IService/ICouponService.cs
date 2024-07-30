using Mango.Web.Models;
namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCoupnsAsync();
        Task<ResponseDto?> GetAllCoupnsByIdAsync(int id);
        Task<ResponseDto?> CreateCoupnsAsync(CouponsDTO couponDto);
        Task<ResponseDto?> UpdateCoupnsAsync(CouponsDTO couponDto);
        Task<ResponseDto?> DeleteCoupnsAsync(int id);        
    }
}
