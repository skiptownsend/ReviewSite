using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReviewSite_Web.Models.DTO;

namespace ReviewSite_Web.Models.VM
{
    public class ProductReviewCreateVM
    {
        public ProductReviewCreateVM()
        {
            ProductReview = new ProductReviewCreateDTO();
        }
        public ProductReviewCreateDTO ProductReview { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ProductList { get; set; }
    }
}
