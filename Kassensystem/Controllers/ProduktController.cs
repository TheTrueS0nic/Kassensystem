using Kassensystem.DAL;
using Kassensystem.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Kassensystem.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class ProduktController : ControllerBase
    {
        private readonly IServiceLogger _logger;
        private readonly IProductRepository _productRepository;
        public ProduktController(IProductRepository productRepository, IServiceLogger logger) 
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        [HttpGet(nameof(GetProducts))]
        public IActionResult GetProducts()
        {
            _logger.Log("GetProducts was a success.");
            return Ok(_productRepository.GetProducts());
        }

        [HttpGet(nameof(GetProductById))]
        public IActionResult GetProductById(int productId)
        {
            _logger.Log("GetById was a success.");
            return Ok(_productRepository.GetProductById(productId));
        }
        [HttpPost(nameof(InsertProduct))]
        public IActionResult InsertProduct(Product product)
        {
            _productRepository.InsertProduct(product);
            _logger.Log("Product successfully added.");
            return Ok();
        }
        [HttpDelete(nameof(DeleteProduct))]
        public IActionResult DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
            _logger.Log("Product successfully removed.");
            return Ok();
        }
        [HttpPatch(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
            _logger.Log("Product successfully updated.");
            return Ok();
        }
    }
}
