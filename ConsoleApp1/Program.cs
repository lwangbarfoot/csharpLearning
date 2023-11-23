using ConsoleApp1;
using ConsoleApp1.Adapter;

// Original functionality using LegacyClass
Console.WriteLine("------------Legacy Class's Original Functionality --------------");
LegacyClass legacyClass = new LegacyClass();
legacyClass.DoWork();
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine();


// New functionality using IOurNewInterface through the adapter
Console.WriteLine("------------Legacy Class adapted to new interface  -------------");
INewInterface newInterface = new LegacyToNewInterfaceAdapter(legacyClass);
int result = newInterface.DoNewWork();
Console.WriteLine($"Adapter Result: {result}");
Console.WriteLine("----------------------------------------------------------------");

