namespace InheritanceClassLibrary;

public interface IFlyable
{
    void Fly();
}
public interface ISwimmable
{
    void Swim();
}

public class Duck : ISwimmable, IFlyable //In C#, Multiple inheritance is possible only through interfaces due to naming constraints
{ 
    public void Fly()
    {
        Console.WriteLine("Duck Flies");
    }

    public void Swim()
    {
        Console.WriteLine("Duck Swims");
    }
}
