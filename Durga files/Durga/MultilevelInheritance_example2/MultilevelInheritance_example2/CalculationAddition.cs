using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance_example2
{
    public  class CalculationAddition
    {
       // public string Name { get; set; }
       public int Number1 { get; set; }
        public int Number2 { get; set; }        
        public int Number3 { get; set; }

        public void  CalculationAdditionMethod()
        {
            int number4 = Number1 + Number2;
            Console.WriteLine("the addition of number4 is:"+number4);


        }
    }
}
