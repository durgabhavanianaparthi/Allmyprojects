using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_segregationPrinciple_Example
{
    //public class Durga : Qualification1
    //{
    //    public void Ssc()
    //    {
    //        Console.WriteLine("she is completed Ssc and she got 550 marks");
    //    }
    //    public void Intermediate()
    //    {
    //        Console.WriteLine("she is completed Intermediate And she got 887 marks");
    //    }
    //    public void UG()
    //    {

    //    }
    //    public void Pg()
    //    {

    //    }
    //    public void PHD()
    //    {
    //    }
    //}
    public  class Durga : Qualification1
    {
        public void Ssc()
        {
            Console.WriteLine("she is completed Ssc and she got 92 %");
        }
        public void Intermediate()
        {
            Console.WriteLine("she is completed Intermediate And she got 77 %");
        }
      
    }
}
