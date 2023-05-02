

using AbstractFactory.Abstarct_Interface;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactory
{
    public class LaptopFactory : ISystemFactory
    {
        public ISystemType systems()
        {
            return new LaptopSystem();
        }

        public ISystemWarranty warranty()
        {
            return new LaptopWarranty();
        }
    }

}
