using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_segregationPrinciple_Example
{
    public class Uma : Qualification1, Qualification2
    {
        public void Ssc()
        {
            Console.WriteLine("she was completed UG and she got 82 % marks");
        }
        public void Intermediate()
        {
            Console.WriteLine("she was completed Ssc and she got 89% marks");
        }
        public void UG()
        {
            Console.WriteLine("she is completed UG and she got  90% ");
        }
    }
}
