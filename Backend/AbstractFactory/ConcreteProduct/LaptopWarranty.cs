
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class LaptopWarranty : ISystemWarranty
    {
        public string GetWarranty()
        {
            return "18Months";
        }
    }
}
