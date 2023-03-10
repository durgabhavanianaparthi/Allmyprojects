using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class ArrayList
    {
        public void MyMethod()
        {
            try
            {


                var arlist1 = new ArrayList();

                var arlist2 = new ArrayList()
                            {
                                1, "Bill", " ", true, 4.5, null
                            };

                int[] arr = { 100, 200, 300, 400 };

                Queue myQ = new Queue();
                myQ.Enqueue("Hello");
                myQ.Enqueue("World!");

                arlist1.AddRange(arlist2); //adding arraylist in arraylist 
                arlist1.AddRange(arr); //adding array in arraylist 
                arlist1.AddRange(myQ); //adding Queue in arraylist
                for (int i = 0; i < arlist1.Count; i++)
                {
                    Console.WriteLine("the values in arraylist is:" + arlist1);
                }
                Console.WriteLine("the index value of  array list is:" + arlist1[7]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
