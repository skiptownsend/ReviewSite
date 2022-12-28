using ReviewSite_WebAPI.Models;
using System.Linq.Expressions;

namespace ReviewSite_WebAPI.Repository.IRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null);
        Task<Product> Get(Expression<Func<Product, bool>> filter = null);
        Task Create(Product entity);
        Task Remove(Product entity);
        Task Save();
    }
}
