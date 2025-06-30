void IsArmstrongNumber(int num)
{
    int temp, rem;
    double sum = 0;
    temp = num;
    while (num > 0) //153
    {
        rem = num % 10; //3
        sum += Math.Pow(rem, 3);
        num /= 10;
    }
    if (sum == temp)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
IsArmstrongNumber(153);