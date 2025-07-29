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

//✅ Problem 2: Count the Number of Digits in a Number .

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

//✅ Problem 5: Count Digits that Divide the Number
int CountDigitsDividingNumber(int num) //1022 -> 3
{
    int rem, count = 0, original = num;
    while(num > 0) //122 //TC - O(Log N)
    {
        rem = num % 10; //2 2 1
        if(rem!= 0 && original % rem == 0) count++;
        num /= 10; //12 1
    }
    return count;
}
CountDigitsDividingNumber(1022);

//✅ Problem 7: Find Factorial of a Number
long FactorialNaive(int n)
{
    long result = 1;
    for(int i = 2; i <= n; i++) //TC -> O(N)
    {
        result *= i;
    }
    return result;
}
FactorialNaive(5);

long FactorialRecursion(int n)
{
    if (n <= 1) return 1;
    return n * FactorialRecursion(n - 1); //5 * Factorial(4) -> 5 * 4 * 3 * 2 
}
Console.WriteLine(FactorialRecursion(5));

//✅ Problem 8: Count Trailing Zeroes in Factorial
int CountTrailingZeroes(int n) //Math involved
{
    int count = 0;
    for(int i = 5; n/i >= 1; i *= 5)
    {
        count += n / i;
    }
    return count;
}

Console.WriteLine(CountTrailingZeroes(5));

//✅ Problem 9: Check if a Number is Power of 2
bool IsNumberPowerOf2Naive(int n) //16
{
    if (n < 1) return false;
    while (n % 2 == 0)
        n /= 2; //8
    return n == 1;
}

IsNumberPowerOf2Naive(112);

//✅ Problem 11: Sum of Digits of a Number
long SumOfDigits(int num) //123 -> 6
{
    long sum = 0, rem;
    while(num > 0)
    {
        rem = num % 10; // 3 2
        sum += rem; //3 +
        num /= 10; //12
    }
    return sum;
}
SumOfDigits(123);

//✅ Problem 12: Product of Digits of a Number
long ProductOfDigits(int num)
{
    long product = 1; int rem;
    while(num > 0)
    {
        rem = num % 10;
        product *= rem;
        num /= 10;
    }
    return product;
}
ProductOfDigits(1234);

//✅ Problem 13: Sum of Digits Until One Digit (Digital Root)
int SumOfDigitsUntil1Digit(int num) //9867
{
    while(num >= 10) //9867
    {
        int sum = 0, rem;
        while (num > 0)
        {
            rem = num % 10;
            sum += rem;
            num /= 10;
        }
        num = sum;
    }
    return num;
}
Console.WriteLine(SumOfDigitsUntil1Digit(98687));
