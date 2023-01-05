using AutoMapper;
using ReviewSite_Web.Models;
using ReviewSite_Web.Models.DTO;

namespace ReviewSite_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ProductDTO, ProductCreateDTO>().ReverseMap();
            CreateMap<ProductDTO, ProductUpdateDTO>().ReverseMap();
            
            CreateMap<ProductReviewDTO, ProductReviewCreateDTO>().ReverseMap();
            CreateMap<ProductReviewDTO, ProductReviewUpdateDTO>().ReverseMap();
        }
    }
}
