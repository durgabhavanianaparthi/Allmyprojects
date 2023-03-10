using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance_example2
{
    public  class CalculationMultiplication: CalculationAddition
    {
        public void CalculationMultiplicationMethod()
        {
            CalculationAdditionMethod();
            int number5 = Number1 * Number2 * Number1;
            Console.WriteLine(" multiplication of Number5  is :" + number5);

        }
    }
}
