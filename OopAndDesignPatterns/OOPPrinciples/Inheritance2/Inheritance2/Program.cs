using InheritanceClassLibrary;
Dog dog = new Dog();
dog.Sleep();
dog.MakeSound();


Duck duck = new Duck();
duck.Swim();
duck.Fly();

Car car = new Car();
car.Start();
car.Stop();

Airplane airplane = new Airplane();
airplane.Takeoff();
airplane.Land();

FlyingCar flyingCar = new FlyingCar();
flyingCar.Start();
flyingCar.Stop();
flyingCar.Takeoff();
flyingCar.Land();