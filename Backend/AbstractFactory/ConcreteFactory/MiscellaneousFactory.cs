using AbstractFactory.Abstarct_Interface;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactory
{
    public class MiscellaneousFactory:ISystemFactory
    {
        
public ISystemType systems()
        {
            return new MiscellaneousSystem();
        }

        public ISystemWarranty warranty()
        {
            return new MiscellaneousWarranty();
        }
    }
}
