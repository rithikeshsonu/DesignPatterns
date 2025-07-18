//✅ Problem 1: Create Two Threads That Print Odd and Even Numbers
//🔸 Question:
//Write a program where:
//Thread 1 prints even numbers from 0 to 10.
//Thread 2 prints odd numbers from 1 to 9.

//💡 Key Concepts:
//Basic thread creation
//Using Thread class
/*
void PrintEven()
{
    for (int i = 0; i <= 2; i += 2)
    {
        Console.WriteLine($"Even: {i}");
        Thread.Sleep(1000); //1 second
    }
}
void PrintOdd()
{
    for(int i = 1; i < 2; i += 2)
    {
        Console.WriteLine($"Odd: {i}");
        Thread.Sleep(1000);
    }
}
var thread1 = new Thread(PrintEven);
var thread2 = new Thread(PrintOdd);

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

int counter = 0;
void Increment()
{
    for(int i = 0; i < 1000; i++)
    {
        counter++;
    }
}
Thread a = new Thread(Increment);
Thread b = new Thread(Increment);
a.Start();
b.Start();
a.Join();
b.Join();

Console.WriteLine($"counter: {counter}");
*/

//Thread Safety
object lockObj = new object();
int count = 0;
void IncrementSafe()
{
    for(int i = 0; i < 1000; i++)
    {
        lock (lockObj)
        {
            count++;
        }
    }
}

Thread x =  new Thread(IncrementSafe);
Thread y = new Thread(IncrementSafe);
Thread z = new Thread(IncrementSafe);
Thread a1 = new Thread(IncrementSafe);

x.Start();
y.Start();
z.Start();
a1.Start();
x.Join();
y.Join();
z.Join();
a1.Join();
Console.WriteLine(count);