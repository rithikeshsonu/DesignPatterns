bool IsPalindrome(string input)
{
    string reversed =  new(input.Reverse().ToArray());
    return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
}
Console.WriteLine(IsPalindrome("madam"));