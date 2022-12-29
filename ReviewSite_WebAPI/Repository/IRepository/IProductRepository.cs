using ReviewSite_WebAPI.Models;
using System.Linq.Expressions;

namespace ReviewSite_WebAPI.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> UpdateAsync(Product entity);
    }
}
