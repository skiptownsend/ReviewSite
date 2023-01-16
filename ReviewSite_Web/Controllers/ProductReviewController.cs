using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Newtonsoft.Json;
using ReviewSite_Web.Models;
using ReviewSite_Web.Models.DTO;
using ReviewSite_Web.Services;
using ReviewSite_Web.Services.IServices;

namespace ReviewSite_Web.Controllers
{
    public class ProductReviewController : Controller
    {
        private readonly IProductReviewService _productReviewService;
        private readonly IMapper _mapper;
        public ProductReviewController(IProductReviewService productReviewService, IMapper mapper)
        {
            _productReviewService = productReviewService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexProductReview()
        {
            List<ProductReviewDTO> list = new();

            var response = await _productReviewService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductReviewDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
    }
}
