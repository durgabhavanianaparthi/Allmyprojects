using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronousVsAsynchronous
{
    public  class BreakfastAsync
    {
        public async Task PreparingTea()
        {
            await Task.Run(async () =>
            {
                Console.WriteLine("Iam Preparing Tea"); 
               await Task.Delay(80000);
                Console.WriteLine("Tea is Ready");
            });
        }


        public async Task PreparingIdly()
        {
            await Task.Run(async () =>
            {
                Console.WriteLine("Iam Preparing Idly");
                await  Task.Delay(3000);
                Console.WriteLine("Idly is Ready");
            });


        }

        public async Task PreparingBoilingEggs()
        {
            await Task.Run(async () =>
            {
                Console.WriteLine("Boiling the eggs");
              await  Task.Delay(2000);
                Console.WriteLine("Eggs is Boiled");
            });

        }
        public async Task Asynchronous()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = PreparingTea();
            var task2 = PreparingIdly();
            var task3 = PreparingBoilingEggs();


            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine(" Asynchronous Execution Time:" + watch.ElapsedMilliseconds);


        }
    }
}

