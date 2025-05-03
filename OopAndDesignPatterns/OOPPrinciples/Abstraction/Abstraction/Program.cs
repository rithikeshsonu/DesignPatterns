// Abstract class
using ClassLibrary1;
class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        dog.MakeSound();
        dog.Sleep();

        IVehicle car = new Car();
        car.Drive();
        car.Stop();
    }
}
