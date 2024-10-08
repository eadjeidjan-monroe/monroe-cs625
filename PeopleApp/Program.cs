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

Console.Read();

