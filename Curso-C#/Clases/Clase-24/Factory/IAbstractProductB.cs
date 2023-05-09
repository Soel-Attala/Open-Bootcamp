using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_24.Factory
{
    public interface IAbstractProductB
    {
        string MethodB();
        string OtherMethodB(IAbstractProductA colaborator);
    }
}
