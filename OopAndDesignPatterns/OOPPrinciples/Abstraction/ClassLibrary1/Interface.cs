namespace ClassLibrary1
{
    public interface IVehicle
    {
        void Drive();
        void Stop();
    }
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping...");
        }
    }
}
