namespace Composition_LooseCoupling;

interface IEngine
{
    void Start();
}
internal class PetrolEngine : IEngine
{
    public void Start() => Console.WriteLine("Petrol engine started");
}
internal class ElectricEngine : IEngine
{
    public void Start() => Console.WriteLine("Electric engine started");
}
class Car
{
    private readonly IEngine _engine;
    public Car(IEngine engine)
    {
        _engine = engine;
    }
    public void Drive()
    {
        _engine.Start();
    }
}