

using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Abstarct_Interface
{
    public interface ISystemFactory
    {
        ISystemWarranty warranty();
        ISystemType systems();
    }
}
