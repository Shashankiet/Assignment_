


using AbstractFactory.Abstarct_Interface;
using AbstractFactory.ConcreteFactory;
using Shared_Layer;

namespace AbstractFactory
{
    public class ProductSystemFactory
    {
        public ISystemFactory Create(Product product)
        {
            ISystemFactory returnValue = null;
            if (product.Category == "Laptop")
            {
                returnValue = new LaptopFactory();
            }
            else if (product.Category == "Smartphone")
            {
                returnValue = new SmartphoneFactory();

            }
            else
            {
                returnValue = new MiscellaneousFactory();
            }
           
            return returnValue;
        }
    }
}