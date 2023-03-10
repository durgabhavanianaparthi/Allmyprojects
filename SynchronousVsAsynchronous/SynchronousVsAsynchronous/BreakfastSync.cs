using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronousVsAsynchronous
{
    public  class BreakfastSync
    {
        public void  PreparingTea()
        { 
                Console.WriteLine("Iam Preparing Tea(sync)");
                Thread.Sleep(8000);
                Console.WriteLine("Tea is Ready(sync)");
        }


        public void  PreparingIdly()
        {
                Console.WriteLine("Iam Preparing Idly(sync)");
                Thread.Sleep(3000);
                Console.WriteLine("Idly is Ready(sync)");
        }

        public void  PreparingBoilingEggs()
        {
                Console.WriteLine("Boiling the eggs(sync)");
                Thread.Sleep(2000);
                Console.WriteLine("Eggs is Boiled(sync)");
        }
        public void Synchronous()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

           PreparingTea();
           PreparingIdly();
            PreparingBoilingEggs();

            watch.Stop();
            Console.WriteLine(" Synchronous Execution Time:" + watch.ElapsedMilliseconds);


        }
    }
}
