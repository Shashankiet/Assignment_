using AbstractFactory.AbstractProduct;


namespace AbstractFactory.ConcreteProduct
{
    public class SmarphoneWarranty : ISystemWarranty
    {
        public string GetWarranty()
        {
            return "12Months";
        }
    }
}
