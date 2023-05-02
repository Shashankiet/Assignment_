using Bussiness_Layer.Services;
using Logger;
using Microsoft.AspNetCore.Mvc;
using Shared_Layer;

namespace Presentation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILog _log;

        private readonly IProductServices _productServices;

        public ProductsController(IProductServices productServices)
        {
         
            _productServices= productServices;
            _log = Log.GetInstance;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            _log.LogAction("Get All The Products");
            return await _productServices.GetAllProduct();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            _log.LogAction("Get  The Product By Id "+id);
            var product=await _productServices.GetProductById(id);
            return product;
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<int> PutProduct(int id, Product product)
        {
            _log.LogAction("Updated the Product with Id "+id);
            var result = await _productServices.UpdateProduct(id, product);
            return result;
        }

        // POST: api/Products
        [HttpPost]
        public async Task<Product> PostProduct(Product product)
        {
            _log.LogAction("Added New product");
            var result = await _productServices.AddProduct(product);

            return result;
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<Product> DeleteProduct(int id)
        {
            _log.LogAction("Deleted The Product With Id "+id);
            var product = await _productServices.DeleteProduct(id);
            return product;
        }
        [Route("Search/{name}")]
        [HttpGet]
        public async Task<List<Product>> GetProductByTitle(string name,[FromQuery] int pageNumber,
                                             [FromQuery] int pageSize)
        {
            _log.LogAction("Searched Product With Title StartWith " + name);

            var result = await _productServices.GetProductBySearch(name,pageNumber,pageSize);

            return result;
        }
       

    }
}
