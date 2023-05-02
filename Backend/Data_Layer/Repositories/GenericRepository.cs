using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context) {
            _context = context;
        }
        public async Task<TModel> AddProduct(TModel product)
        {
            _context.Set<TModel>().Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<TModel> DeleteProduct(int id)
        {
            var product = await _context.Set<TModel>().FindAsync(id);
            if (product == null)
            {
                return product;
            }
            _context.Set<TModel>().Remove(product);
            _ = await _context.SaveChangesAsync();

            return product;

        }

        public async Task<List<TModel>> GetAllProduct()
        {
            var data = await _context.Set<TModel>().ToListAsync();

            return data;
        }

        public async Task<TModel> GetProductById(int id)
        {
            var data = await _context.Set<TModel>().FindAsync(id);
            return data;
        }


       
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
