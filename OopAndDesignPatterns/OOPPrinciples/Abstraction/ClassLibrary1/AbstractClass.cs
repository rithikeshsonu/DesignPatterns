namespace ClassLibrary1;

public abstract class Animal
{
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping...");
    }
}

// Concrete class
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark...");
    }
}
