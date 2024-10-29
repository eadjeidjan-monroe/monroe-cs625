

using VehicleProduction;

MercedesCClass myCClass = new MercedesCClass();

myCClass.WarmSeats("very hot");

myCClass.MoveForward();

Console.WriteLine(
	myCClass.Fly()
);

//Vehicle myVehicle = new Vehicle(); //wrong




//MercedesEClass myMercedes = new MercedesEClass();

//myMercedes.Color = "Black";
//myMercedes.Weight = 5000;
// Console.WriteLine(
//	myMercedes.MoveForward()
//	 );
//myMercedes.LaneAssist();

//myMercedes.CarLocation();

//Console.WriteLine("Lock Status:" +
//		myMercedes.RemoteLock(false)
//	);


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
