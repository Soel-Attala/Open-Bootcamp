using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_24.Factory
{
    public class ConcreteFactory : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA;
        }
        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProdcutB;
        }
    }
}
