namespace OopAndDesignPatterns.OOPPrinciples.Polymorphism
{
    class Vehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }

        //virtual - Can be overridden by sub classes.
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        }
    }
}
