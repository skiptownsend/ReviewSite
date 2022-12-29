using AutoMapper;
using ReviewSite_WebAPI.Models;
using ReviewSite_WebAPI.Models.DTO;

namespace ReviewSite_WebAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductCreateDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();

            CreateMap<ProductReview, ProductReviewDTO>().ReverseMap();
            CreateMap<ProductReview, ProductReviewCreateDTO>().ReverseMap();
            CreateMap<ProductReview, ProductReviewUpdateDTO>().ReverseMap();
        }
    }
}
