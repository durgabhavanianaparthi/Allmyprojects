using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    public class Finding_number
    {
        public void Mymethod()
        {



            //int i;
            //Console.WriteLine("Enter array of size:");
            //int lengthofarray = int.Parse(Console.ReadLine());
            //int[] str = new int[lengthofarray];
            ////Console.WriteLine("enter elements");
            //for (i = 0; i < str.Length; i++)
            //{
            //    // Console.WriteLine($"enter element if index {i}:");
            //    Console.WriteLine("Element in index     " + i + ":");
            //    str[i] = int.Parse(Console.ReadLine());
            //}
            int[,] numbers = { { 2, 3 }, { 4, 5 } };

            // old element
            Console.WriteLine("Old element at index [0, 0] : " + numbers[0, 0]);

            // assigning new value
            numbers[0, 0] = 222;

            // new element
            Console.WriteLine("New element at index [0, 0] : " + numbers[0, 0]);
            int[,] number = { { 2, 3, 9 }, { 4, 5, 9 } };

            for (int i = 0; i < number.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.Write(number[i, j] + " ");

                }
                Console.WriteLine();

            }
        }
    }
}
