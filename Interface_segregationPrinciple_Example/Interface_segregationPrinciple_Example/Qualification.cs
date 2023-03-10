using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_segregationPrinciple_Example
{
    //public  interface Qualification
    //{
    //    public void Ssc();
    //    public void Intermediate();
    //    public void UG();
    //    public void Pg();
    //    public void PHD();

    //}
    public interface Qualification1
    {
        public void Ssc();
        public void Intermediate();
        

    }
    public interface Qualification2
    {
        
        public void UG();
       

    }
    public interface Qualification3
    {
       
        public void Pg();
        public void PHD();

    }
}
