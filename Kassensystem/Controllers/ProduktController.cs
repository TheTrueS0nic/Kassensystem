using Kassensystem.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Kassensystem.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class ProduktController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProduktController(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }
        [HttpGet(nameof(GetProducts))]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetProducts());
        }

        [HttpGet(nameof(GetProductById))]
        public IActionResult GetProductById(int productId)
        {
            return Ok(_productRepository.GetProductById(productId));
        }
        [HttpPost(nameof(InsertProduct))]
        public IActionResult InsertProduct(Product product)
        {
            _productRepository.InsertProduct(product);
            return Ok();
        }
    }
}
