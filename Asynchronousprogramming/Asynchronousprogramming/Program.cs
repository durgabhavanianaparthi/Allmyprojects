﻿// See https://aka.ms/new-console-template for more information
using Asynchronousprogramming;




//static async Task LongProcess1()
//{
//    Console.WriteLine("LongProcess 1 Started");

//    await Task.Delay(4000); // hold execution for 4 seconds

//    Console.WriteLine("LongProcess 1 Completed");

//  //  return 10;
//}

//static async Task LongProcess2()
//{
//    Console.WriteLine("LongProcess 2 Started");

//    await Task.Delay(4000); // hold execution for 4 seconds

//    Console.WriteLine("LongProcess 2 Completed");

//   // return 20;
//}

////static void DisplayResult(int val)
////{
////    Console.WriteLine(val);
////}
//static async Task Main(string[] args)
//{
//    LongProcess1();
//    LongProcess2();

//    //Task<int> result1 = LongProcess1();
//    //Task<int> result2 = LongProcess2();

//    //do something here
//    //Console.WriteLine("After two long processes.");

//    //int val = await result1; // wait untile get the return value
//    //DisplayResult(val);

//    //val = await result2; // wait untile get the return value
//    //DisplayResult(val);

//    //Console.ReadKey();
//} 
Asynchronous obj = new Asynchronous();
obj.LongProcess1();
obj.LongProcess2();