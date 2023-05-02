using Shared_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Repositories
{
   public interface IGenericRepository<TModel>where TModel : class
    {
        Task<List<TModel>> GetAllProduct();
        Task<TModel> GetProductById(int id);
        Task<TModel> AddProduct(TModel product);
        Task<TModel> DeleteProduct(int id);
        Task SaveAsync();

    }
}
