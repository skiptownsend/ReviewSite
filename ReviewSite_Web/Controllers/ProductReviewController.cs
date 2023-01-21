using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Newtonsoft.Json;
using ReviewSite_Web.Models;
using ReviewSite_Web.Models.DTO;
using ReviewSite_Web.Models.VM;
using ReviewSite_Web.Services;
using ReviewSite_Web.Services.IServices;
using System.Collections.Generic;

namespace ReviewSite_Web.Controllers
{
    public class ProductReviewController : Controller
    {
        private readonly IProductReviewService _productReviewService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductReviewController(IProductReviewService productReviewService, IProductService productService, IMapper mapper)
        {
            _productReviewService = productReviewService;
            _productService = productService;
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

        public async Task<IActionResult> CreateProductReview()
        {
            ProductReviewCreateVM productReviewVM = new();
            var response = await _productService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                productReviewVM.ProductList = JsonConvert.DeserializeObject<List<ProductDTO>>
                    (Convert.ToString(response.Result)).Select(i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
            }
            return View(productReviewVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProductReview(ProductReviewCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productReviewService.CreateAsync<APIResponse>(model.ProductReview);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexProductReview));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> UpdateProductReview(int Id)
        {
            ProductReviewUpdateVM productReviewVM = new();
            var response = await _productReviewService.GetAsync<APIResponse>(Id);
            if (response != null && response.IsSuccess)
            {
                ProductReviewDTO model = JsonConvert.DeserializeObject<ProductReviewDTO>(Convert.ToString(response.Result));
                productReviewVM.ProductReview = _mapper.Map<ProductReviewUpdateDTO>(model);
            }
            response = await _productService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                productReviewVM.ProductList = JsonConvert.DeserializeObject<List<ProductDTO>>
                    (Convert.ToString(response.Result)).Select(i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
                return View(productReviewVM);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProductReview(ProductReviewUpdateVM model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productReviewService.UpdateAsync<APIResponse>(model.ProductReview);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexProductReview));
                }
            }
            return View(model);
        }

        //public async Task<IActionResult> DeleteProductReview(int productId)
        //{
        //    var response = await _productService.GetAsync<APIResponse>(productId);
        //    if (response != null && response.IsSuccess)
        //    {
        //        ProductDTO model = JsonConvert.DeserializeObject<ProductDTO>(Convert.ToString(response.Result));
        //        return View(model);
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteProductReview(ProductReviewDeleteVM model)
        //{
        //    var response = await _productService.DeleteAsync<APIResponse>(model.Id);
        //    if (response != null && response.IsSuccess)
        //    {
        //        return RedirectToAction(nameof(IndexProductReview));
        //    }

        //    return View(model);
        //}
    }
}
        