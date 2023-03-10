//
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedList sl = new SortedList ();

        sl.Add(1, "Tim");
        sl.Add(4, "Steve");
        sl.Add(2, "Bill");
        sl.Add(3 , "Tom");

        if (sl.ContainsValue("Bill"))
        {
            Console.WriteLine("This name is already in the list");
        }
        else
        {
            sl.Add("005", "James");
        }

        ICollection key = (ICollection)sl.Keys;
        ICollection value = (ICollection)sl.Values;

        foreach (int  k in key)
        {
            Console.WriteLine(k + ": " + sl[k]);
        }
    }
    
}