using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetAllCouponsAsync(string userId);
        Task<ResponseDto?> UpsertCartAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponAsync(int id);

    }
}
