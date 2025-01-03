using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supplier2.Data;
using Supplier2.DTO;
using Supplier2.Model;

namespace Supplier2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private IMapper mapper;
        private ProductRepo repo;
        public ProductController(IMapper _mapper, ProductRepo _repo)
        {
            mapper = _mapper;
            repo = _repo;

        }
        [HttpPost]
        public ActionResult CreatProduct(DTOCreateProduct dTOCreate)
        {
            var model = mapper.Map<Product>(dTOCreate);
            if (repo.AddProduct(model))
                return Ok();
            else
                return BadRequest();
        }
        [HttpGet]
        public ActionResult<IEnumerable<DTOReadProduct>> GetProducts()
        {
            var products = repo.GetProducts();
            return Ok(mapper.Map<IEnumerable<DTOReadProduct>>(products));
        }
        [HttpGet("{id}", Name = "GetProduct")]
        public ActionResult<DTOReadProduct> GetProduct(int id)
        {
            var product = repo.GetProduct(id);
            if (product != null)
                return Ok(mapper.Map<DTOReadProduct>(product));
            else
                return NotFound();
        }
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, DTOCreateProduct dTOCreate)
        {
            var product = mapper.Map<Product>(dTOCreate);
            product.Id = id;
            if (repo.UpdateProduct(product))
                return Ok();
            else
                return NotFound();

        }
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var product = repo.GetProduct(id);
            if (product != null)
            {
                repo.DeleteProduct(product);
                return Ok();
            }
            else
                return NotFound();
        }
    }
}
