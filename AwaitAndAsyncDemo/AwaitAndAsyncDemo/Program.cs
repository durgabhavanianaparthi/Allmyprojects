// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    Console.WriteLine("Main Method Started......");
    SomeMethod();
    Console.WriteLine("Main Method End");
    Console.ReadKey();

 async static void SomeMethod()
{
    Console.WriteLine("Some Method Started......");
    //Thread.Sleep(TimeSpan.FromSeconds(10));
    await Task.Delay(TimeSpan.FromSeconds(10));
    Console.WriteLine("\n");
    Console.WriteLine("Some Method End");
}