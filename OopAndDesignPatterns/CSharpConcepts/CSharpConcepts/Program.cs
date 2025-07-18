//🧠 Let’s Begin with ref, out, and in
using CSharpConcepts;

void Swap(int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
}
int a = 1, b = 2;
Swap(a, b);
Console.WriteLine($"a = {a}, b = {b}");

//✅ Using ref (Correct way):
void SwapUsingRef(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
int x = 1, y = 2;
SwapUsingRef(ref x,ref y);
Console.WriteLine($"x = {x}, y =  {y}");

//ref allows passing variables by reference, so any change in method reflects outside.
//Must be initialized before passing.

//✅ Problem 2: Try parsing string to int using out
bool TryParseInt(string input, out int number)
{
    return int.TryParse(input, out number);
}
string userInput = "123";
if(TryParseInt(userInput, out int result))
{
    Console.WriteLine($"Parsed Successfully: {result}");
}
else
{
    Console.WriteLine("Invalid number");
}

//🔍 Explanation:
//out means the parameter must be assigned inside the method.
//It doesn’t need to be initialized before calling.
//Common use case: TryParse, TryGetValue.

//✅ Problem 3: Demonstrate in parameter
void PrintSquare(in int n)
{
    //n += 3; //Cannot modify 'in' variables
    Console.WriteLine(n * n);
}
int num = 5;
PrintSquare(num);
//🔍 Explanation:
//in passes by reference but makes the parameter read-only inside the method.
//Useful for performance with large structs.

//📌 Next Set: params, readonly, const
void PrintNumbers(params int[] nums)
{
    foreach(int num in nums)
    {
        Console.WriteLine(num);
    }
}
PrintNumbers(7, 1, 2, 2, 3);
//🔍 Explanation:
//params allows passing variable number of arguments.
//Only one params per method, and it must be the last parameter.

//✅ Problem 5: Difference between const and readonly
//class Sample
//{
//    public const double pi = 3.14; // Compile-time constant
//    public readonly int MyId; // Set at runtime (once)
//    public Sample(int id)
//    {
//        MyId = id; // Allowed only in constructor
//    }
//}

//✅ Problem 10: is, as, typeof, nameof
object obj = "Hello";
if(obj is string s) //is checks type.
{
    Console.WriteLine("Object:" + s);
}
string str = obj as string; //as performs safe cast(returns null if fail).
Console.WriteLine(str);
Console.WriteLine(typeof(string));
Console.WriteLine(nameof(obj));