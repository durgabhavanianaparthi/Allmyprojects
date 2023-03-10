using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_inheritance
{
    public class AirthematicOperations
    {
        public int num1 { get; set; }
        public int num2{ get; set; }
        public int num3 { get; set; }

        public AirthematicOperations(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        public void MyMethod( )
        {
            num3 = num1 + num2;
            Console.WriteLine("The sum of two numbers is :" + num3);
        }
    }
}
