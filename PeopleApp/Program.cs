using System.Text.Json.Serialization;
using PackLibrary;

//Person harry = new()
//{
//	Name = "Harry", 
//	Born = new(2000,1,1,14,0,0,TimeSpan.Zero)

//};

//harry.WriteToConsole();
//Console.Read();


//Implementing functionality using methods.

Person john = new Person()
{
	Name = "John"

};
Person jane = new Person()
{
	Name = "Jane"
};
Person sarah = new Person()
{
	Name = "Sarah"
};

//call the instance method to marry John and Jane
john.Marry(jane);

//output John's spouses
john.OutputSpouses();
//output Jane's spouses
jane.OutputSpouses();

//output Sarah's spouses
sarah.OutputSpouses();

//call instance method to make baby
Person baby1 = john.ProcreateWith(jane);
baby1.Name = "John II";
Console.WriteLine($"{baby1.Name} was born on {baby1.Born}");


//call the static method to make a baby
Person baby2 = Person.Procreate(john, sarah);
baby2.Name = "John III";

john.WriteChildrenToConsole();
sarah.WriteChildrenToConsole();
jane.WriteChildrenToConsole();

string s1 = "Hello ";
string s2 = "World";
string s3 = s1 + s2;
Console.WriteLine(s3);

//Person.Marry(john, jane);

if (john + sarah)
{
	Console.WriteLine($"{john.Name} and {sarah.Name} successfully got married.");
}

Person baby3 = john * sarah;

baby3.Name = "John IV";

Person baby4 = john * jane;
baby4.Name = "John V";
john.WriteChildrenToConsole();
john.OutputSpouses();
sarah.WriteChildrenToConsole();
jane.WriteChildrenToConsole();
Console.Read();

