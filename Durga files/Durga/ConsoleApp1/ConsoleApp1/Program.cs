using ConsoleApp1;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// using String data type 
//string a = "durga";
//Console.WriteLine(a);
//int age;
//Console.WriteLine("age:");
//string b =" years old";
//Console.WriteLine(b);

string? a;
string? ch;
Console.WriteLine("Enter name:");
a =  Console.ReadLine();

Console.WriteLine("Enter Search Char:");
ch = Console.ReadLine();

FindStringLength objFindStringLength = new FindStringLength();

bool isFound = objFindStringLength.IsCharExistsInString(a, ch);

if (isFound)//if (result == true)
{
    Console.WriteLine("Found");
}
else
{
    Console.WriteLine(" Not Found");
}

Console.ReadLine();

//char a;
//Console.WriteLine("Enter name:");
//a = Convert.ToString(Console.ReadLine());
//int index = String a();

//Console.WriteLine("enter b value:");
//b = Convert.ToInt32(Console.ReadLine());

//c = a % b;
//Console.WriteLine("module of 2 numbers:" + c);



//AdditionOf2 objAdditionOf2 = new AdditionOf2(); ;
//objAdditionOf2.Sum(a, b);

//int d = objAdditionOf2.Difference(a, b);
//Console.WriteLine("Difference of 2 numbers:" + d);

//FindReminder objFindReminder = new FindReminder();
//objFindReminder.Reminder(a, b);

//CheckPrime objCheckPrime=new CheckPrime();
//bool result = objCheckPrime.SayPrime(a);

//if (result)//if (result == true)
//{
//    Console.WriteLine(a + " is Prime No");
//}
//else
//{
//    Console.WriteLine(a + " is Not Prime No");
//}


