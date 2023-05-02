using Shared_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Services
{
    public interface IProductServices
    {
        Task<List<Product>> GetAllProduct();
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetProductBySearch(string name, int pageNumber, int pageSize);
        Task<Product> AddProduct(Product product);
        Task<Product> DeleteProduct(int id);
        Task<int> UpdateProduct(int id, Product product);
    }
}
