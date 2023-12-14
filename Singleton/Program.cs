// See https://aka.ms/new-console-template for more information

using Singleton;

Console.WriteLine("Hello, World!");
//Singleton is when you only want one instance of a class to exist in your program.



int n = 45543567;
var x = new object();
var y = new object();


var s = MySingleton.Instance;
var s2 = MySingleton.Instance;

MySingleton2.Instance2 = new();
var s3 = new MySingleton2();
s3.Instance = new();

// two types of memory
// stack
// 0001: 45543567
// 0002: h0001
// 0003: h0003
// 0004: h0005
// 0005: h0005

// reference type: class
// heap
// 0001: x-begin
// 0002: x-end
// 0003: y-begin
// 0004: y-end
// 0005: s-begin
// 0006: s-end
