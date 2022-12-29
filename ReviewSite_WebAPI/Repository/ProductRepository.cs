using Microsoft.EntityFrameworkCore;
using ReviewSite_WebAPI.Data;
using ReviewSite_WebAPI.Migrations;
using ReviewSite_WebAPI.Models;
using ReviewSite_WebAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace ReviewSite_WebAPI.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Products.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
