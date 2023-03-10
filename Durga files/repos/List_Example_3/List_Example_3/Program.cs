// See https://aka.ms/new-console-template for more information
using List_Example_3;

Console.WriteLine("Hello, World!");
AllMethodsAboutEmployee obj = new AllMethodsAboutEmployee();
bool choice = true;
do
{
    Console.WriteLine("Select one Option\n1.Add\n2.Remove\n3.Search\n4.RemoveAtIndex\n5.Insert\n6.Count\n7.Display\n8.Exit");
    int selectedNumber = int.Parse(Console.ReadLine());

    switch (selectedNumber)
    {
        case 1:
            obj.Add();
            Console.WriteLine("***************************");
            break;
        case 2:
            obj.Remove();
            Console.WriteLine("***************************");
            break;
        case 3:
            obj.Search();
            Console.WriteLine("***************************");
            break;
        case 4:
            obj.RemoveAtIndex();
            Console.WriteLine("***************************");
            break;
        case 5:
            obj.Insert();
            Console.WriteLine("***************************");
            break;
        case 6:
            obj.Count();
            Console.WriteLine("***************************");
            break;
        case 7:
            obj.Display();
            Console.WriteLine("***************************");
            break;
        case 8:
            choice = false;
            break;
    }
}
while (choice);
