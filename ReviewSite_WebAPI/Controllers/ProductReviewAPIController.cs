using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using ReviewSite_WebAPI.Data;
using ReviewSite_WebAPI.Models;
using ReviewSite_WebAPI.Models.DTO;
using ReviewSite_WebAPI.Repository.IRepository;
using System.Net;

namespace ReviewSite_WebAPI.Controllers
{
    [Route("api/ProductReviewAPI")]
    [ApiController]
    public class ProductReviewAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductReviewAPIController> _logger;
        private readonly IProductReviewRepository _dbProductReview;
        private readonly IProductRepository _dbProduct;
        public ProductReviewAPIController(IProductReviewRepository dbProductReview, IProductRepository dbProduct, IMapper mapper, ILogger<ProductReviewAPIController> logger)
        {
            _dbProductReview = dbProductReview;
            _dbProduct = dbProduct;
            _mapper = mapper;
            _logger = logger;
            this._response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetProductReviews()
        {
            try
            {
                IEnumerable<ProductReview> productReviewList = await _dbProductReview.GetAllAsync();
                _response.Result = _mapper.Map<List<ProductReviewDTO>>(productReviewList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetProductReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetProductReview(int id)
        {
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Get Product Review Error with Id " + id);
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var productReview = await _dbProductReview.GetAsync(u => u.Id == id);
                if (productReview == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<ProductReviewDTO>(productReview);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateProductReview([FromBody] ProductReviewCreateDTO createDTO)
        {
            try
            {
                if (createDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                if(await _dbProduct.GetAsync(u => u.Id == createDTO.ProductId) == null)
                {
                    ModelState.AddModelError("CustomError", "Product Id is Invalid!");
                    return BadRequest(ModelState);
                }
                ProductReview productReview = _mapper.Map<ProductReview>(createDTO);
                await _dbProductReview.CreateAsync(productReview);

                _response.Result = _mapper.Map<ProductReviewDTO>(productReview);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetProductReview", new { id = productReview.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id:int}", Name = "DeleteProductReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteProductReview(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                var productReview = await _dbProductReview.GetAsync(u => u.Id == id);
                if (productReview == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    return NotFound(_response);
                }
                await _dbProductReview.RemoveAsync(productReview);
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut("{id:int}", Name = "UpdateProductReview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateProductReview(int id, [FromBody] ProductReviewUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.Id)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest(_response);
                }
                if (await _dbProduct.GetAsync(u => u.Id == updateDTO.ProductId) == null)
                {
                    ModelState.AddModelError("CustomError", "Product Id is Invalid!");
                    return BadRequest(ModelState);
                }
                ProductReview productReview = _mapper.Map<ProductReview>(updateDTO);

                await _dbProductReview.UpdateAsync(productReview);
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

    }
}
