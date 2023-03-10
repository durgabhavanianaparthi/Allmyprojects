using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronousprogramming
{
    public class Asynchronous
    {
        public async Task LongProcess1()
        {
            Console.WriteLine("LongProcess 1 Started");

             Task.Delay(2000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess 1 Completed");

            //  return 10;
        }

        public  async Task LongProcess2()
        {
            Console.WriteLine("LongProcess 2 Started");

             Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess 2 Completed");

            // return 20;
        }
    }

}
