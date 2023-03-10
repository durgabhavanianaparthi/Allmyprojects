using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance_example2
{
    public class ClaculationReminder: CalculationMultiplication
    {
        public  void ClaculationReminderMethod()
        {
            CalculationMultiplicationMethod();
            int Number6 = Number1 % Number2;
            Console.WriteLine("the reminder of number6 is:" + Number6);
            Console.ReadLine();
        }

    }
}
