

using AbstractFactory.Abstarct_Interface;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory

{
    public class ProductSystemManager
    {
        ISystemFactory _ISystemFactory;
        public ProductSystemManager(ISystemFactory iSystemFactory)
        {
           _ISystemFactory= iSystemFactory;
        }
        public string GetSystemDetails()
        {
            ISystemWarranty systemWarranty= _ISystemFactory.warranty();
            ISystemType systemType = _ISystemFactory.systems();
            string returnValue = string.Format("{0} {1}", systemWarranty.GetWarranty(),  systemType.GetSystemType());
            string WarrantyDescription= returnValue.Trim()!="" ? returnValue.Trim() : "No Warranty";
            return WarrantyDescription;
        }
       
        
}
}
