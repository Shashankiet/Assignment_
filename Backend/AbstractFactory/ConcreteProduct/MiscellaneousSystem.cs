﻿using AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteProduct
{
    public class MiscellaneousSystem : ISystemType
    {
        public string GetSystemType()
        {
            return "";
        }
    }
}
