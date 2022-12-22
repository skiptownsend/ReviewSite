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
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            return Ok(ProductStore.productList);
            
        }

        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProductDTO> GetProduct(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var product = ProductStore.productList.FirstOrDefault(u => u.Id == id);
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
        public ActionResult<ProductDTO> CreateProduct([FromBody]ProductDTO productDTO)
        {
            if(productDTO == null)
            {
                return BadRequest(productDTO);
            }
            if(productDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            productDTO.Id = ProductStore.productList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            ProductStore.productList.Add(productDTO);

            return CreatedAtRoute("GetProduct", new { id = productDTO.Id }, productDTO);
        }
    }
}
