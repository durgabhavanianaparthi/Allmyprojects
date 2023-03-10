using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_example
{
   public  class Bird
    {
        public  string bName ="parrot";
        public void BirdMethod()
        {
            Console.WriteLine("the bird name is " + bName);
        }
    }

}
