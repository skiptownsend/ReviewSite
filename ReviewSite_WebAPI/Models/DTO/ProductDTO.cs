using System.ComponentModel.DataAnnotations;

namespace ReviewSite_WebAPI.Models.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
