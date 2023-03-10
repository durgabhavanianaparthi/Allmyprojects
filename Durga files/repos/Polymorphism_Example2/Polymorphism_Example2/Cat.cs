using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example2
{
    public class Cat:Animal 
    {
        public override  void Eat()
        {
            base.Eat();
           string color =" Red";
            Console.WriteLine(color);
        }
    }
}
