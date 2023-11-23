using PatternsPractice._04_FactoryPattern;
using PatternsPractice.AdapterPattern;
using PatternsPractice.Factory_Pattern;
using PatternsPractice.ProxyPattern;
using PatternsPractice.StrategyPattern;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("*****************Adapter Pattern*********************");
Console.WriteLine("----------Using Sony Original Functionality----------");
LegacySonyClass sonyTv = new LegacySonyClass();
sonyTv.PowerOn();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("----------Using New functionality for Sony TV via adapter----------");
SonyTvUsingNewTurnOnAdapter sonyAdapter = new SonyTvUsingNewTurnOnAdapter(sonyTv);
sonyAdapter.TurnOn();

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("*****************Proxy Pattern*********************");
Console.WriteLine("-----------Using RealImage directly--------------------------------------");
IImage image1 = new RealImage("large_image1.jpg");
image1.Display();// Image will be loaded and displayed

Console.WriteLine("-----------Using Proxy Image---------------------------------------------");
IImage image2 = new ProxyImage("large_IMG_2.jpg");
image2.Display();// Image will be loaded and displayed (proxy will control the access)

Console.WriteLine("--The second time, the image will not be loaded again due to the proxy---");
image2.Display();// Image will be displayed without loading again

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("****************Strategy Pattern*********************");
Console.WriteLine("-----------Using Credit Card at first------------------------------------");
PaymentContext context = new PaymentContext(new CreditCardPayment());
context.ProcessPayment(100.0);

Console.WriteLine("-----------Switching strategy as Cash at runtime-------------------------");
context.SetPaymentStragety(new CashPayment());
context.ProcessPayment(50.0);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("****************Factory Pattern*********************");

ShapeFactory shapeFactory = new ShapeFactory();

// Creating different shapes using the factory
IShape circle = shapeFactory.CreateShape("circle");
IShape square = shapeFactory.CreateShape("square");
IShape triangle = shapeFactory.CreateShape("triangle");

Console.WriteLine("-----------Drawing the shapes------------------------------------");
// Drawing the shapes
circle.Draw();
square.Draw();
triangle.Draw();

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("****************Func method*********************");

// Example 1: Func with no input parameters and an int result
Func<int> getRandomNumber = () => new Random().Next(1, 101);
int randomNumber = getRandomNumber();
Console.WriteLine($"Random Number: {randomNumber}");

// Example 2: Func with one input parameter and a string result
Func<string, string> greet = (name) => $"Hello, {name}!";
string greeting = greet("John");
Console.WriteLine(greeting);