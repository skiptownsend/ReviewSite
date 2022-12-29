using Microsoft.EntityFrameworkCore;
using ReviewSite_WebAPI.Data;
using ReviewSite_WebAPI.Migrations;
using ReviewSite_WebAPI.Models;
using ReviewSite_WebAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace ReviewSite_WebAPI.Repository
{
    public class ProductReviewRepository : Repository<ProductReview>, IProductReviewRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductReviewRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ProductReview> UpdateAsync(ProductReview entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.ProductReviews.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
