using Microsoft.AspNetCore.Mvc;
using ReviewSite_WebAPI.Models;

namespace ReviewSite_WebAPI.Controllers
{
    [Route("api/ReviewSiteAPI")]
    [ApiController]
    public class ReviewSiteAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "White T-Shirt" },
                new Product { Id = 2, Name = "Red T-Shirt" }
            };
        }
    }
}
