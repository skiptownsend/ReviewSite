using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReviewSite_Web.Models.DTO;

namespace ReviewSite_Web.Models.VM
{
    public class ProductReviewUpdateVM
    {
        public ProductReviewUpdateVM()
        {
            ProductReview = new ProductReviewUpdateDTO();
        }
        public ProductReviewUpdateDTO ProductReview { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ProductList { get; set; }
    }
}
