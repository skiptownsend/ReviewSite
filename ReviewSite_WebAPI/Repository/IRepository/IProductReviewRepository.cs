using ReviewSite_WebAPI.Models;
using System.Linq.Expressions;

namespace ReviewSite_WebAPI.Repository.IRepository
{
    public interface IProductReviewRepository : IRepository<ProductReview>
    {
        Task<ProductReview> UpdateAsync(ProductReview entity);
    }
}
