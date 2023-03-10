// See https://aka.ms/new-console-template for more information
using MultilevelInheritance_example2;

Console.WriteLine("Hello, World!");
ClaculationReminder objClaculationReminder = new ClaculationReminder();
  // objClaculationReminder.ClaculationReminderMethod();
//Console.ReadLine();Console.ReadLine();
objClaculationReminder.Number1 = 6;
objClaculationReminder.Number2 = 3;
objClaculationReminder.Number3 = 3;
objClaculationReminder.ClaculationReminderMethod();
Console.ReadLine();