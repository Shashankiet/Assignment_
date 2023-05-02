using Bussiness_Layer.Services;
using Moq;
using Presentation_Layer.Controllers;
using Shared_Layer;

namespace Bussiness_Test
{
    public class Tests
    {
        private Mock<IProductServices> productServices;
        private ProductsController productController;
        [SetUp]
        public void Setup()
        {
            productServices = new Mock<IProductServices>();
            productController = new ProductsController(productServices.Object);
        }
        private List<Product> GetProductsData()
        {
            List<Product> productsData = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "IPhone",
                Description = "IPhone 12",
                Price = 55000,
                Discount = 10,
                Brand="Apple",
                ImageUrl="google.com",
                Category="Smartphone"
            },
             new Product
             {
                 Id = 2,
                 Title = "IPhone2",
                 Description = "IPhone max pro",
                 Price = 55000,
                 Discount = 10,
                 Brand="Apple",
                 ImageUrl="google.com",
                 Category="Smartphone"
             },
             new Product
            {
                Id = 3,
                Title = "Samsung",
                Description = "LightWeight",
                Price = 55000,
                Discount = 10,
                Brand="Samsung",
                ImageUrl="google.com",
                Category="Laptop"
            },
        };
            return productsData;
        
    }

         [Test]
        public async Task GetProductList_ShouldReturnProductList_WhenProductExists()
        {
            var productList = GetProductsData();
            productServices.Setup(x => x.GetAllProduct())
                .ReturnsAsync(productList);

            //act
            var productResult =await productController.GetProducts();

            //assert
            Assert.NotNull(productResult);
            Assert.That(productResult, Has.Count.EqualTo(3));
            Assert.True(productList.Equals(productResult));

        }
        [Test]
     
        public async Task GetProductByID_ShouldReturnProduct_WhenProductExists()
        {
            //arrange
            var productList = GetProductsData();
            productServices.Setup(x => x.GetProductById(2))
                .ReturnsAsync(productList[1]);

            //act
            var productResult = await productController.GetProduct(2);

            //assert
            Assert.NotNull(productResult);
            Assert.That(productResult.Id, Is.EqualTo(productList[1].Id));
            Assert.True(productList[1].Id == productResult.Id);
            Assert.True(productList[1].Equals(productResult));
        }

        [Test]
        public async Task AddProduct_ShouldReturnProduct_IfCreated()
        {
            //arrange
            var productList = GetProductsData();
            productServices.Setup(x => x.AddProduct(productList[0]))
                .ReturnsAsync(productList[0]);
          

            //act
            var productResult =await productController.PostProduct(productList[0]);

            //assert
            Assert.NotNull(productResult);
            Assert.That(productResult.Id, Is.EqualTo(1));
            Assert.True(productResult.Id==1);
        }
        [Test]
        public async Task DeleteProduct_ReturnRemovedProduct()
        {
            //arrange
            var productList = GetProductsData();
            productServices.Setup(x => x.DeleteProduct(2))
                .ReturnsAsync(productList[1]);

            //act
            var productResult = await productController.DeleteProduct(2);

            //assert
            Assert.NotNull(productResult);
            Assert.That(productResult.Id, Is.EqualTo(2));
            Assert.That(productResult.Id, Is.EqualTo(2));
        }

       
    }
}
