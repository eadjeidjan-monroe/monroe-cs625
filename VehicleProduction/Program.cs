

using VehicleProduction;

MercedesEClass myMercedes = new MercedesEClass();
 Console.WriteLine(
	myMercedes.MoveForward()
	 );
myMercedes.LaneAssist();

myMercedes.CarLocation();

Console.WriteLine("Lock Status:" +
		myMercedes.RemoteLock(false)
	);


//Console.WriteLine("Implementation of Car");


//Car myNewCar = new Car();

//myNewCar.Height = 100;
//myNewCar.Weight = 70;

//Console.WriteLine(myNewCar.MoveReverse());


//Console.WriteLine(myNewCar.MoveForward());
//Console.WriteLine(myNewCar.HonkHorn());



//Console.WriteLine("Implementation of Bus-------------------");
//Bus myNewBus = new Bus();
//Console.WriteLine(myNewBus.MoveForward());
//Console.WriteLine(myNewBus.HonkHorn());
Console.ReadKey();
