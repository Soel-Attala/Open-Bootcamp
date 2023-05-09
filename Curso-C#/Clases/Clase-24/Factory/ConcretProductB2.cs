using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_24.Factory
{
    public class ConcretProductB2
    {
        public class ConcreteProductB2 : IAbstractProductB
        {
            public string MethodB()
            {
                return "From Method A in ConcreteProductB1";
            }
            public string OtherMethod(IAbstractProductA colaborator)
            {
                var result = colaborator.MethodA();
                return $"The colaboration result A is{result}";
            }
        }
    }
}
