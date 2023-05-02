

using AbstractFactory.Abstarct_Interface;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactory




{
    public class SmartphoneFactory : ISystemFactory
    {
        public ISystemType systems()
        {
            return new SmartPhoneSystem();
        }

        public ISystemWarranty warranty()
        {
            return new SmarphoneWarranty();
        }
    }

}
