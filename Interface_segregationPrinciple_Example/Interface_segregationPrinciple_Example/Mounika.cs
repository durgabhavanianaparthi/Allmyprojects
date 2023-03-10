using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_segregationPrinciple_Example
{
    public class Mounika : Qualification1, Qualification2, Qualification3
    {
        public void Ssc()
        {
            Console.WriteLine("she is completed Ssc and she got 90 percent");

        }
        public void Intermediate()
        {
            Console.WriteLine("she is completed Intermediate and she got 89 percent");
        }
        public void UG()
        {
            Console.WriteLine("she is completed UG and she got 93 percent");
        }
        public void Pg()
        {
            Console.WriteLine("she is completed Pg and she got 89 percent");
        }

        public void PHD()
        {
            Console.WriteLine("she is completed Phd and she got 72  percent");
        }

    }
      

       
}
