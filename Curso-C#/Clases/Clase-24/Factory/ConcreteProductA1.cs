﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_24.Factory
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string MethodA()
        {
            return "From Method A in ConcreteProductA1";
        }
    }
}
