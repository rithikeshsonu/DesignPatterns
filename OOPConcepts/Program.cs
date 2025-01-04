abstract class Customer //Can only be used as base class. Cant be instantiated.
{
    public abstract void Print();
}
class Customer1 : Customer
{
    public override void Print()
    {
        Console.WriteLine("Print method");
    }
    static void Main()
    {
        //Customer1 c = new();
        Customer c = new Customer1(); //Works same as above line
        c.Print();
    }
}