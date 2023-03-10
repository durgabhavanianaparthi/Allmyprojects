// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");




//HashSet...
Console.WriteLine("HashSet...");
HashSet<string> stringHashSet = new HashSet<string>();
stringHashSet.Add("Vinay");
stringHashSet.Add("Rintu");
stringHashSet.Add("vinaY");
stringHashSet.Add("Vinay");
Console.WriteLine("List of Elements..");
foreach (string s in stringHashSet)
{
    Console.WriteLine(s);
}
//Console.ReadLine();



//Sorted Set
Console.WriteLine("\n\nSorted Set...");



SortedSet<string> stringSortedSet = new SortedSet<string>();
stringSortedSet.Add("Pawan Kalyan");
stringSortedSet.Add("Allu Arjun");
stringSortedSet.Add("Bala Krishna");
stringSortedSet.Add("Vijay Devarakonda");
stringSortedSet.Add("Prabhas");
stringSortedSet.Add("alluArjun");



foreach (string s in stringSortedSet)
{
    Console.WriteLine(s);
}



//Stack...
Console.WriteLine("\n\nStack...");
Stack<int> intStack = new Stack<int>();
intStack.Push(1);
intStack.Push(2);
intStack.Push(30);
intStack.Push(4);
intStack.Push(51);



foreach (int i in intStack)
{
    Console.WriteLine(i);
}



Console.WriteLine("\n peek element " + intStack.Peek());
Console.WriteLine("\n Element Popped " + intStack.Pop());
Console.WriteLine("\n Stack Elements");
foreach (int i in intStack)
{
    Console.WriteLine(i);
}



//Queue...
Console.WriteLine("\nQueue...");
Queue<string> stringQueue = new Queue<string>();
stringQueue.Enqueue("abc");
stringQueue.Enqueue("def");
stringQueue.Enqueue("ghi");



Console.WriteLine("Queue Elements...");
foreach (string st in stringQueue)
{
    Console.WriteLine(st);
}



Console.WriteLine("Peek Element.. " + stringQueue.Peek());
Console.WriteLine("Removed Element.. " + stringQueue.Dequeue());



foreach (string st in stringQueue)
{
    Console.WriteLine(st);
}



//Dictionary...
Console.WriteLine("\nDictionary...");



Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "One");
dictionary.Add(2, "Two");
dictionary.Add(5, "Five");
dictionary.Add(3, "Three");
dictionary.Add(4, "Four");



Console.WriteLine("Dictionary Elements...");
foreach (KeyValuePair<int, string> kvp in dictionary)
{
    Console.WriteLine($"Key : {kvp.Key}, Value  : {kvp.Value}");
}



//Sorted Dictionary....
Console.WriteLine("\nSorted Dictionary..");
SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
sortedDictionary.Add(1, "One");
sortedDictionary.Add(5, "Five");
sortedDictionary.Add(2, "Two");
sortedDictionary.Add(0, "Zero");
sortedDictionary.Add(3, "Three");



Console.WriteLine("Sorted Dictionary... Elements");
foreach (KeyValuePair<int, string> kvp in sortedDictionary)
{
    Console.WriteLine($"key:{kvp.Key}, Value:{kvp.Value}");
}




//Sorted List...
Console.WriteLine("\n\nSorted List...");
SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(1, "One");
sortedList.Add(5, "Five");
sortedList.Add(2, "Two");
sortedList.Add(4, "Four");
sortedList.Add(3, "Three");



Console.WriteLine("Sorted List Elements...");
foreach (KeyValuePair<int, string> kvp in sortedList)
{
    Console.WriteLine($"key:{kvp.Key},Value:{kvp.Value}");
}



//LinkedList...
Console.WriteLine("\n\nLinked List....");
LinkedList<string> list = new LinkedList<string>();
list.AddFirst("Mounika");
list.AddLast("One");
list.AddLast("Two");
list.AddLast("Three");
list.AddFirst("Iam The First");



Console.WriteLine("LinkedList Elements");
foreach (var item in list)
{
    Console.WriteLine(item);
}
//Hashtable//nonGeneric
Hashtable h1 = new Hashtable();
h1.Add(55.89, "Welcome");
h1.Add("A2", 5);
h1.Add(3, "durga");

Console.WriteLine("Key and Value pairs from my_hashtable1:");
h1.Remove(3);
foreach (DictionaryEntry item in h1)
{
    Console.WriteLine("{0} and {1} ", item.Key, item.Value);
}

Console.WriteLine("the hashtable elements is:" +h1.Count);
h1.Clear();

Console.WriteLine("the hashtable elements is:" + h1.Count);



