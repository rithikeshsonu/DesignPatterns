namespace CSharpConcepts
{
    class Sample 
    {
        public const double pi = 3.14; // Compile-time constant
        public readonly int MyId; // Set at runtime (once)
        public Sample(int id)
        {
            MyId = id; // Allowed only in constructor
        }
    }
}
