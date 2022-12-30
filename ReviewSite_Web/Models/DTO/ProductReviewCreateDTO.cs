using System.ComponentModel.DataAnnotations;

namespace ReviewSite_Web.Models.DTO
{
    public class ProductReviewCreateDTO
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ReviewerName { get; set; }
        [Required]
        public string Review { get; set; }
    }
}
