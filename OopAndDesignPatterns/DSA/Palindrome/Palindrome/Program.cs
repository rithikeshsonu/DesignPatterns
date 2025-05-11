bool IsPalindrome(string input)
{
    string reversed = new(input.Reverse().ToArray());
    return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
}
Console.WriteLine(IsPalindrome("madam"));


void SwapNumbers(ref int a, ref int b) //Swapping without a third variable
{
    a = a + b;
    b = a - b;
    a = a - b;
}
int x = 5; int y = 10;
SwapNumbers(ref x, ref y);
Console.WriteLine($"{x}, {y}");