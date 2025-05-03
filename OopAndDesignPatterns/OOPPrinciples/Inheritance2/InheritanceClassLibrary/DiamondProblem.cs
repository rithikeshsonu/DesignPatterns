
using InheritanceClassLibrary;

namespace InheritanceClassLibrary;

//public class A
//{
//    public void DoSomething()
//    {
//        Console.WriteLine("A meth");
//    }
//}
//public class B : A
//{
//    public void DoSomething()
//    {
//        Console.WriteLine("B meth");
//    }
//}

//public class C : A
//{
//    public void  DoSomething()
//    {
//        Console.WriteLine("C Meth");
//    }
//}
//class D : B, C
//{

//}
/// <summary>
/// Class implementation - If has same names, we can't inherit and have diff. implementations. But, with interfaces, we can create different implementations.
/// </summary>
public interface IDriveable
{
    void Start();
    void Stop();
}
public interface IFlyablee
{
    void Takeoff();
    void Land();
}
public class Car : IDriveable
{
    public void Start()
    {
        Console.WriteLine("Car starts");
    }

    public void Stop()
    {
        Console.WriteLine("Car stops");
    }
}
public class Airplane : IFlyablee
{
    public void Land()
    {
        Console.WriteLine("Airplane lands..");
    }

    public void Takeoff()
    {
        Console.WriteLine("Airplane took off");
    }
}
public  class FlyingCar : IFlyablee, IDriveable
{
    Car car = new Car();
    Airplane airplane = new Airplane();
    public void Land()
    {
        airplane.Land();
    }

    public void Start()
    {
        car.Start();
    }

    public void Stop()
    {
        car.Stop();
    }
    public void Takeoff()
    {
        airplane.Takeoff();
    }
}