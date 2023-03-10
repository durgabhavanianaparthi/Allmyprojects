using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    public class Generics<T1, T2>
    {
        public Generics(T1 Parameter1, T2 Parameter2)//constructer
        {
            Param1 = Parameter1;
            Param2 = Parameter2;
        }
        public T1 Param1 { get; }
        public T2 Param2 { get; }
    }
}
        
