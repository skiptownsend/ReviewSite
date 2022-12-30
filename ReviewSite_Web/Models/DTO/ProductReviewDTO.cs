using System.ComponentModel.DataAnnotations;

namespace ReviewSite_Web.Models.DTO
{
    public class ProductReviewDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ReviewerName { get; set; }
        public string Review { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
