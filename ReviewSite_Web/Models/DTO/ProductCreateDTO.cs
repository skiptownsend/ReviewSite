using System.ComponentModel.DataAnnotations;

namespace ReviewSite_Web.Models.DTO
{
    public class ProductCreateDTO
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
