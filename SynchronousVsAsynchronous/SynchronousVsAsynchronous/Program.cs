// See https://aka.ms/new-console-template for more information
using SynchronousVsAsynchronous;

Console.WriteLine("Hello, World!");

BreakfastSync objBreakfastSync = new BreakfastSync();
objBreakfastSync.Synchronous();
BreakfastAsync objBreakfastAsync = new BreakfastAsync();
objBreakfastAsync.Asynchronous();
