namespace InheritanceClassLibrary;
public class Animal
{
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping..");
    }
    public virtual void MakeSound() //Virtual or Abstract members can never be private
    {
        Console.WriteLine("Animal Makes sound");
    }
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        //base.MakeSound();
        Console.WriteLine("Dog barks");
    }
}