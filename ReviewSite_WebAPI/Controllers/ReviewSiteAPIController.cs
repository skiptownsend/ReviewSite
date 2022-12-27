using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<ReviewSiteAPIController> _logger;
        public ReviewSiteAPIController(ApplicationDbContext db, ILogger<ReviewSiteAPIController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts() 
        {
            return Ok(_db.Products.ToList());
        }

        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProductDTO> GetProduct(int id)
        {
            if(id == 0)
            {
                _logger.LogError("Get Product Error with Id " + id);
                return BadRequest();
            }
            var product = _db.Products.FirstOrDefault(u => u.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<ProductDTO> CreateProduct([FromBody]ProductCreateDTO productDTO)
        {
            if(_db.Products.FirstOrDefault(u => u.Name.ToLower() == productDTO.Name.ToLower()) != null)
            {
                _logger.LogError("Create Product Error with Name " + productDTO.Name);
                ModelState.AddModelError("", "Product name already exists!");
            }
            if(productDTO == null)
            {
                return BadRequest(productDTO);
            }
            Product model = new()
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                ImageUrl = productDTO.ImageUrl
            };
            _db.Products.Add(model);
            _db.SaveChanges();
            return CreatedAtRoute("GetProduct", new { id = model.Id }, model);
        }

        [HttpDelete("{id:int}", Name = "DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteProduct(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var product = _db.Products.FirstOrDefault(u => u.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            _db.Products.Remove(product);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateProduct(int id, [FromBody] ProductUpdateDTO productDTO)
        {
            if(productDTO == null || id != productDTO.Id)
            {
                return BadRequest();
            }
            Product model = new()
            {
                Id = productDTO.Id,
                Name = productDTO.Name,
                Description = productDTO.Description,
                ImageUrl = productDTO.ImageUrl
            };
            _db.Products.Update(model);
            _db.SaveChanges();
            return NoContent();
        }
    }
}
