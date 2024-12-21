﻿//using OopAndDesignPatterns.OOPPrinciples.Inheritance;
//using OopAndDesignPatterns.OOPPrinciples.Polymorphism;
using OopAndDesignPatterns.SOLIDPrinciples.OpenClosed;

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
Shape shape = new();
shape.Length = 10;
shape.Width = 20;
shape.Radius = 5;
shape.ShapeType = ShapeType.Circle;
shape.ShapeType = ShapeType.Rectangle;

var res = shape.CalculateArea();
Console.WriteLine(res);

//Liskov Substitution Principle
//Objects of sub class should be able to substitute objects of superclass without affecting the correctness of the program
