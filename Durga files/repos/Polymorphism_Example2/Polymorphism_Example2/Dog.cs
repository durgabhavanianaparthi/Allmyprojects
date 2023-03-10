using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Polymorphism_Example2
{
    public   class Dog:Animal
    {
       //public  string color = "black";
        public  override  void Eat()
        {
            //Console.WriteLine(base.color);
            //Console.WriteLine(color);
            // base.Eat();
            // Console.WriteLine("eating Apple");
            string color = "white";
            Console.WriteLine(color);

        }

    }
}
