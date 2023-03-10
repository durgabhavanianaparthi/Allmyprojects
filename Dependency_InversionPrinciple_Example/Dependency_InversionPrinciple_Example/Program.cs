// See https://aka.ms/new-console-template for more information
using Dependency_InversionPrinciple_Example;

Console.WriteLine("Hello, World!");

List<IMessage> messages = new List<IMessage>();
Email em = new Email();
SMS s= new SMS();
messages.Add(em);
messages.Add(s);
Notification obj = new Notification(messages);
obj.Send();

