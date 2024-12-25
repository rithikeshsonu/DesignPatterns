//using OopAndDesignPatterns.OOPPrinciples.Inheritance;
//using OopAndDesignPatterns.OOPPrinciples.Polymorphism;
//using OopAndDesignPatterns.SOLIDPrinciples.LiskovSubstitution;
//using OopAndDesignPatterns.SOLIDPrinciples.OpenClosed;

////Inheritance
//Console.WriteLine("Inheritance");
//var car = new OopAndDesignPatterns.OOPPrinciples.Inheritance.Car();
//car.Brand = "Ford";
//car.NumberOfDoors = 6;
//car.NumberOfWheels = 6;
//car.Year = 1992;
//car.Start();
//car.Stop();

//Bike bike = new();
//bike.Brand = "Haya";

//Console.WriteLine("Polymorphism");
/*
List<object> vehicles = new();
vehicles.Add(new OopAndDesignPatterns.OOPPrinciples.Polymorphism.Car { Brand = "Toyota", Model = "Sample", NumberOfDoors = 6, Year = 1992, });
vehicles.Add(new Motorcycle { Brand = "Harley", Model = "Test", Year = 2000 });

var bike = new Bike();
bike.Brand = "Haya";

foreach (var vehicle in vehicles)
{
    if (vehicle is Car)
    {
        var car = (Car)vehicle;
        car.Start();
    }
    if (vehicle is Motorcycle motorcycle)
    {
        motorcycle.Start();
    }
}
*/
//Using above approach, we will have to modify code for everytime we add a new Vehicle type.
//So, if we want to avoid this. Instead of giving a generic object. We can define it with Parent class type. Demonstrated below...
//List<Vehicle> vehicles =
//[
//    new Car { Brand = "Toyota", Model = "Sample", NumberOfDoors = 6, Year = 1992, },
//    new Motorcycle { Brand = "Harley", Model = "Test", Year = 2000 },
//    new Vehicle{Brand = "Vehicle", Model = "Test3", Year = 2020},
//];
//foreach (var vehicle in vehicles)
//{
//    vehicle.Start(); // Runtime polymorphism //Dynamically checks the type of object and invokes method calling. This is where virtual and override comes into action. 
//}


//SOLID
//Single Responsibilty Principle

//Open Closed Principle
//Software entities - Functions/Modules/classes should be open for extension but closed for modification
//Shape shape = new();
//shape.Length = 10;
//shape.Width = 20;
//shape.Radius = 5;
//shape.ShapeType = ShapeType.Circle;
//shape.ShapeType = ShapeType.Rectangle;

//var res = shape.CalculateArea();
//Console.WriteLine(res);

//Liskov Substitution Principle
//Objects of sub class should be able to substitute objects of superclass without affecting the correctness of the program
//Shape rectangle = new Rectangle()
//{
//    Height = 10,
//    Width = 8,
//};
//Console.WriteLine($"Calculated Area of rectangle: {rectangle.Area}");

//Shape square = new Square() 
//{
//    SideLength = 5 
//};

//Console.WriteLine($"calculated area of square: {square.Area}");

//Interface Segregation Principle
//Clients(classes) should not be forced to depend on interfaces they do not use
//Meaning you segregate Interfaces as you need.
//using OopAndDesignPatterns.SOLIDPrinciples.InterfaceSegregation;

//Circle circle = new Circle();
//circle.Radius = 5.5;
//Console.WriteLine(circle.Area());
//Sphere sphere = new Sphere();
//sphere.Radius = 4.5;
//sphere.Area();
//sphere.Volume();

//Dependency Inversion Principle
//High level modules should not depend on low level modules. Both should depend on Abstractions
//Components rely on Abstractions rather than concrete Imlementations(Classes)
//using OopAndDesignPatterns.SOLIDPrinciples.DependencyInversion;
//Car car = new(new Engine()); //This is dependency Injection
//car.StartCar();


//Design Patterns:
//Behavioral Design Patterns:
//Observer Design Pattern.
//The observer design pattern involves an ovbect known as the subject maintainaing a list of its dependent objects, known as observers and notifying them aiutomatically when the state changes.
//using OopAndDesignPatterns.DesignPatterns.Behavioral.Observer;

//School school1 = new("School1");
//School school2 = new("School1");
//User user1 = new("User1");
//User user2 = new("User2");

//NewsAgency newsAgency = new();
//newsAgency.RegisterObserver(user1);
//newsAgency.RegisterObserver(school1);
//newsAgency.NotifyObservers("News 1");
//Console.WriteLine();
//newsAgency.RegisterObserver(user2);
//newsAgency.RegisterObserver(school2);
//newsAgency.NotifyObservers("News 2");
//Console.WriteLine();
//newsAgency.UnregisterObserver(user1);
//newsAgency.UnregisterObserver(school2);
//newsAgency.NotifyObservers("News3");

//Factory method Pattern
//Create objects without exposing the creation logic to the client and refer to newly created object using a common interface
//using OopAndDesignPatterns.DesignPatterns.Creational.FactoryMethod;
////This vastly supports OCP AND SRP, Where you can go ahead and add many more payment methods
//IPayment payment = PaymentFactory.create(PaymentMethod.GooglePay); //Returns the instance of the class which can be used next -> Also RunTime polymorphism
//payment.Pay(1000);


//Abstract Factory Pattern
//Factory of Factories

//using OopAndDesignPatterns.DesignPatterns.Creational.AbstractFactory;
//Before using Provider
//IInternationalFactory factory = new EnglandFactory(); 
//ILanguage language = factory.CreateLanguage();
//ICapitalCity capital = factory.CreateCapital();
//language.Greet();
//Console.WriteLine($"Total population: {capital.GetPopulation()}");
//Console.WriteLine($"Top Attractions:{string.Join(", ", capital.ListTopAttractions())}");

//After using Provider -> 
//Country country = Country.England;
//ILanguage language = InternationalProvider.CreateLanguage(country);
//ICapitalCity capital = InternationalProvider.CreateCapital(country);
//Console.WriteLine($"{country}");
//Console.WriteLine(capital.GetType().Name);
//language.Greet();
//Console.WriteLine($"Total population: {capital.GetPopulation()}");
//Console.WriteLine($"Top Attractions:{string.Join(", ", capital.ListTopAttractions())}");

//Singleton Pattern
//The singleton pattern is great for storing app configuration settings, logging info, session info, authentication tokens and making its information available globally via a single instance, ensuring that it is the same throughout the app. (For eg: GetTenantDetails())
using OopAndDesignPatterns.DesignPatterns.Creational.Singleton;

var settings = AppSettings.GetInstance();
settings.Set("app_name", "DesignPatternsMastery");
settings.Set("app_creator", "Rithikesh");
Console.WriteLine(settings.Get("app_name"));
Test.Run();