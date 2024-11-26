// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using GenericsDemo;

var newGenListString = new GenericList<string>();

newGenListString.Add("this is some text");

var newGenListInt = new GenericList<int>();
newGenListInt.Add(545);

Console.ReadKey();
