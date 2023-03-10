using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_inheritance
{
    public class Multiplication : AirthematicOperations
    {
        public Multiplication(int a,int b):base(a,b)
        {

        }
        public void MyMethod2()
        {
            MyMethod();
            num3 = num1 * num2;
            Console.WriteLine("the product if two numbers is :" + num3);
        }
    }
}

   
