using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyClassLibraryTest3_UsingInterfacesAnd_Inheritace.Class1;

namespace MyClassLibraryTest3_UsingInterfacesAnd_Inheritace
{
    public class Marks : Student
    {
        public double TotalMarks { get; set; }
        public void MarksMethod()
        {
            StudentMethod();
            double telugu;
            double english;
            double hindhi;
            double social;
            double maths;
            double science;

            Console.WriteLine("Enter Telugu Marks :");
            telugu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English Marks :");
            english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hondhi Marks :");
            hindhi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Social Marks  :");
            social = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks  :");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Science Marks :");
            science = Convert.ToInt32(Console.ReadLine());
            TotalMarks = telugu + english + hindhi + social + maths + science;
            Console.WriteLine("Total Marks is :" + TotalMarks);






        }


    }
}



