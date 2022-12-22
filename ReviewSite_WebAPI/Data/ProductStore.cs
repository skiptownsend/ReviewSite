using ReviewSite_WebAPI.Models;
using ReviewSite_WebAPI.Models.DTO;

namespace ReviewSite_WebAPI.Data
{
    public static class ProductStore
    {
        public static List<ProductDTO> productList = new List<ProductDTO>
        {
                new ProductDTO { Id = 1, Name = "White T-Shirt" },
                new ProductDTO { Id = 2, Name = "Red T-Shirt" }
        };
    }
}
