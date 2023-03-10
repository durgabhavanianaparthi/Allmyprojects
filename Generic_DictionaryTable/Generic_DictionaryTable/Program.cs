 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Dictionary<int, string> My_dict =
                   new Dictionary<int, string>();

// Adding key/value pairs in the Dictionary
// Using Add() method
My_dict.Add(1, "C");
My_dict.Add(2, "C++");
My_dict.Add(3, "C#");

 foreach (KeyValuePair<int, string> element in My_dict)
{
    Console.WriteLine("Key:- {0} and Value:- {1}",
                      element.Key, element.Value);
}