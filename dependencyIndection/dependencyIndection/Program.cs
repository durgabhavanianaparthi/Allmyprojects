// See https://aka.ms/new-console-template for more information

//

using dependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel;
public class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        var txt = services
            .AddSingleton<MainImpClass, MainImpClass>().BuildServiceProvider().GetService<MainImpClass>().GetSchoolNames();
        Console.WriteLine(txt);



        var AllList = services
            .AddSingleton<MainImpClass, MainImpClass>()
            .BuildServiceProvider()
            .GetService<MainImpClass>()
            .GetAllLists();
        foreach (var item in AllList)
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine(AllList);
        Console.ReadLine();
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        throw new NotImplementedException();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ISchoolRepository, SchoolRepository>();
        services.AddTransient<IAuthor, Author>();
    }
}