using AbstractFactory;
using AbstractFactory.Abstarct_Interface;
using Data_Layer;
using Data_Layer.Repositories;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Shared_Layer;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IGenericRepository<Product> _repository;
        public ProductServices(IGenericRepository<Product> repository)
        {
            _repository= repository;
        }
        public async Task<Product> AddProduct(Product product)
        {
            ISystemFactory factory = new ProductSystemFactory().Create(product);
            ProductSystemManager manager = new ProductSystemManager(factory);
            product.Warranty = manager.GetSystemDetails();
            return await _repository.AddProduct(product);
        }

        public async Task<Product> DeleteProduct(int id)
        {
            return await _repository.DeleteProduct(id);
        }

        public async Task<List<Product>> GetAllProduct()
        {
            return await _repository.GetAllProduct();
        }

        public async Task<Product> GetProductById(int id)
        {
          return await _repository.GetProductById(id);
        }

        public async Task<List<Product>> GetProductBySearch(string name,int pageNumber,int pageSize)
        {
            var data = await _repository.GetAllProduct();
            var res = data.Where(r => r.Title.ToLower().StartsWith(name.ToLower()) || name == "**").
                Skip((pageNumber - 1) * pageSize)
               .Take(pageSize).ToList();
            return res;
        }

        public async Task<int> UpdateProduct(int id, Product product)
        {
            var data = await _repository.GetProductById(id);
            if (data == null)
            {
                return 0;
            }
            data.Title = product.Title;
            data.Price = product.Price;
            data.Category = product.Category;
            data.Description = product.Description;
            data.Brand = product.Brand;
            data.ImageUrl = product.ImageUrl;
            data.Discount = product.Discount;
            ISystemFactory factory = new ProductSystemFactory().Create(product);
            ProductSystemManager manager = new ProductSystemManager(factory);
             data.Warranty = manager.GetSystemDetails();
            await _repository.SaveAsync();
            return 1;
        }

    }
}
