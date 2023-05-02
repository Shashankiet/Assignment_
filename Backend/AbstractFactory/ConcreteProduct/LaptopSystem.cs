
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class LaptopSystem : ISystemType
    {
        public string GetSystemType()
        {
            string systeminfo = string.Format("{0} {1} {2}", "Processor", "Camera", "Battery");
            return systeminfo;
        }
    }
}
