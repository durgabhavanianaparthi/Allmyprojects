// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
try { 
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
for (int i = 0; i < arlist2.Count; i++)
{
        Console.WriteLine(  arlist2[i]);
}
Console.WriteLine("the index value of  array list is:" + arlist1[7]);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
            catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
        
