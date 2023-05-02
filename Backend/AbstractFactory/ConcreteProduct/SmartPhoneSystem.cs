
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class SmartPhoneSystem : ISystemType
    {
        public string GetSystemType()
        {
            string systeminfo = string.Format("{0} {1} {2}", "Charger","Battery","Earphone");
            return systeminfo;
        }
    }
}
