using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using ReviewSite_WebAPI.Data;
using ReviewSite_WebAPI.Models;
using ReviewSite_WebAPI.Models.DTO;

namespace ReviewSite_WebAPI.Controllers
{
    [Route("api/ReviewSiteAPI")]
    [ApiController]
    public class ReviewSiteAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly ILogger<ReviewSiteAPIController> _logger;
        public ReviewSiteAPIController(ApplicationDbContext db, IMapper mapper, ILogger<ReviewSiteAPIController> logger)
        {
            _db = db;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts() 
        {
            IEnumerable<Product> productList = await _db.Products.ToListAsync();
            return Ok(_mapper.Map<List<ProductDTO>>(productList));
        }

        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDTO>> GetProduct(int id)
        {
            if(id == 0)
            {
                _logger.LogError("Get Product Error with Id " + id);
                return BadRequest();
            }
            var product = await _db.Products.FirstOrDefaultAsync(u => u.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ProductDTO>(product));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProductDTO>> CreateProduct([FromBody]ProductCreateDTO createDTO)
        {
            if(await _db.Products.FirstOrDefaultAsync(u => u.Name.ToLower() == createDTO.Name.ToLower()) != null)
            {
                _logger.LogError("Create Product Error with Name " + createDTO.Name);
                ModelState.AddModelError("", "Product name already exists!");
            }
            if(createDTO == null)
            {
                return BadRequest(createDTO);
            }
            Product model = _mapper.Map<Product>(createDTO);
            await _db.Products.AddAsync(model);
            await _db.SaveChangesAsync();
            return CreatedAtRoute("GetProduct", new { id = model.Id }, model);
        }

        [HttpDelete("{id:int}", Name = "DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var product = await _db.Products.FirstOrDefaultAsync(u => u.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductUpdateDTO updateDTO)
        {
            if(updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest();
            }
            Product model = _mapper.Map<Product>(updateDTO);
            _db.Products.Update(model);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
