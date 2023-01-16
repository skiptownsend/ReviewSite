using ReviewSite_Web.Models.DTO;

namespace ReviewSite_Web.Services.IServices
{
    public interface IProductReviewService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(ProductReviewCreateDTO dto);
        Task<T> UpdateAsync<T>(ProductReviewUpdateDTO dto);
        Task<T> DeleteAsync<T>(int id);
    }
}
