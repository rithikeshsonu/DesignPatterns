//✅ Problem 1: Check if a Number is a Palindrome
bool IsPalindromeNaive(int num) //121
{
    string strArr = num.ToString();
    char[] chars = strArr.ToCharArray(); // 1 2 1
    Array.Reverse(chars);
    return strArr == new string(chars);
}
IsPalindromeNaive(121);
bool IsPalindromeOptimal(int num) //121
{
    int rem, temp = num;
    int revNum = 0;
    while(num > 0) //121
    {
        rem = num % 10; //1 2 1
        revNum = revNum * 10 + rem; //1 10 + 2 = 12 120 + 1
        num /= 10; //12 1 0
    }
    return revNum == temp;
}
Console.WriteLine(IsPalindromeOptimal(122));

//✅ Problem 2: Count the Number of Digits in a Number

int CountDigitsNaive(int num) //121
{
    return num.ToString().Length;
}
Console.WriteLine(CountDigitsNaive(121));

int CountDigitsOptimal(int num)
{
    if(num == 0) return 1;
    int count = 0;
    while(num > 0) //TC: O(Log N)
    {
        count++;
        num /= 10;
    }
    return count;
}
Console.WriteLine(CountDigitsOptimal(121));

//✅ Problem 3: Check if a Number is Prime
//🔸Naive Solution:
//Loop from 2 to n-1 and check divisibility
bool IsPrimeNaive(int num) //7
{
    for(int i = 2; i < num; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}
Console.WriteLine(IsPrimeNaive(17));

//🔹Optimal Solution:
//Only loop till √n and check divisibility
bool IsPrimeOptimal(int num)
{
    for(int i = 2; i * i <= num; i++) //🔸 Time Complexity: O(√n)
    {
        if(num % i == 0) return false;
    }
    return true;
}
IsPrimeOptimal(17);

//✅ Problem 4: Find GCD(Greatest Common Divisor) of Two Numbers
int GCD(int a, int b) //10, 15
{
    int gcd = 1;
    for(int i = 1; i <= Math.Min(a, b); i++)
    {
        if (a % i == 0 && b % i == 0)
            gcd = i;
    }
    return gcd;
}
GCD(10, 15);