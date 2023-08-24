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

    }
}
