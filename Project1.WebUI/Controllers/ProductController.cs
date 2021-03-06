using Microsoft.AspNetCore.Mvc;
using Project1.BL;


namespace Project1.WebUI
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("productbyid/{id}")]
        public BL.Product GetProductById(int id) 
        {
            return _productRepository.GetProductById(id);
        }
    }
}