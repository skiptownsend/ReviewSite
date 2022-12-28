using Microsoft.EntityFrameworkCore;
using ReviewSite_WebAPI.Data;
using ReviewSite_WebAPI.Migrations;
using ReviewSite_WebAPI.Models;
using ReviewSite_WebAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace ReviewSite_WebAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Product entity)
        {
            await _db.Products.AddAsync(entity);
            await Save();
        }

        public async Task<Product> Get(Expression<Func<Product, bool>> filter = null)
        {
            IQueryable<Product> query = _db.Products;
            if(filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            IQueryable<Product> query = _db.Products;
            if(filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task Remove(Product entity)
        {
            _db.Products.Remove(entity);
            await Save();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
