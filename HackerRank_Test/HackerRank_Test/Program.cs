// See https://aka.ms/new-console-template for more information
using HackerRank_Test;

Console.WriteLine("Hello, World!");
//FindingNonRepeatedString obj = new FindingNonRepeatedString();
FindingNonRepeatedString.first_non_repeated("DurgaBhavani");
// input = "DurgaBhavani";
var result = FindingNonRepeatedString.first_non_repeated("DurgaDBhavani");
if (result.index == -1)
{
    Console.WriteLine("No non-repeated letter found.");
}
else
{
    Console.WriteLine("The first non-repeated letter is: " + result.letter + " at index " + result.index); 
}



//FindingNonRepeatedString.non_repeated_indexes("DurgaBhavaniAnaparthi");
//var result = FindingNonRepeatedString.non_repeated_indexes("DurgaBhavaniAnaparthi");
//if (result.Count == 0)
//{
//    Console.WriteLine("No non-repeated letter found.");
//}
//else
//{
//    Console.Write("The non-repeated letters are at indexes: ");
//    foreach (var item in result)
//    {
//        // Console.Write(index + " ");
//        Console.Write("Letter " + item.Item2 + " at index " + item.Item1 + " , ");
//    }
//    Console.WriteLine();
//}