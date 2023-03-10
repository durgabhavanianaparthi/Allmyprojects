using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AdditionOf2
    {
        public void Sum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Sum of Numbers: " + z);
        }

        public int Difference(int x, int y)
        {
            int z = x - y;
            return z;
        }
    }
}
