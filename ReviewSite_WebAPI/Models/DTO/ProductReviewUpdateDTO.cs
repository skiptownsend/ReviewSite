using System.ComponentModel.DataAnnotations;

namespace ReviewSite_WebAPI.Models.DTO
{
    public class ProductReviewUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ReviewerName { get; set; }
        [Required]
        public string Review { get; set; }
    }
}
