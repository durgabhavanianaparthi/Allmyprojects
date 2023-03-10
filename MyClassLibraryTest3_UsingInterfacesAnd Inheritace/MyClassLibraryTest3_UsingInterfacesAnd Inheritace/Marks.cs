using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryTest3_UsingInterfacesAnd_Inheritace
{
    public  class Grade: Marks
    {


      
            public void GradeMethod()
            {
                MarksMethod();
                double avgMarks = TotalMarks / 6;
                Console.WriteLine("the averafe marks is :" + avgMarks);
                if (avgMarks > 60)
                {
                    Console.WriteLine("The student grade is A");
                }
                if (avgMarks > 50 && avgMarks < 60)
                {
                    Console.WriteLine("the student grade is B");

                }
                if (avgMarks > 35 && avgMarks < 50)
                {
                    Console.WriteLine("The student grade is C");
                }

            }
        
    }
}
