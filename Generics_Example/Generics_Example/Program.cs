// See https://aka.ms/new-console-template for more information
using Generics_Example;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
//Generics obj = new Generics(T1 Param1, T2 Param2);

        var obj1 = new Generics<int, string>(100, "One Hundred");
        Console.WriteLine($"{obj1.Param1} : {obj1.Param2}");
        var obj2 = new Generics<string, string>("Dot Net Tutorails", "Welcome to C#.NET");
        Console.WriteLine($"{obj2.Param1} : {obj2.Param2}");
        var obj3 = new Generics<int, int>(100, 200);
        Console.WriteLine($"{obj3.Param1} : {obj3.Param2}");
        Console.ReadKey();
    
