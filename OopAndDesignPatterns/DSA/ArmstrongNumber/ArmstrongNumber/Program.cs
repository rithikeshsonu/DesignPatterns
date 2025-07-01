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


void IsPalindrome(int num) //121
{
    int temp = num, rem;
    int revNum = 0;
    while(num > 0)
    {
        rem = num % 10; //1, 2, 1
        revNum = revNum * 10 + rem; //1 -> 10 + 2 -> 12 -> 120 + 1 -> 121
        num /= 10; //12 1 0
    }
    if(revNum == temp)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
IsPalindrome(121);

string ReverseString(string input) //Convert string to char array
{
    char[] reversed = input.ToCharArray(); //reversed = ['x', 'e', 'r', 'e', 'x']
    int j = 0;
    for(int i = input.Length - 1; i >= 0; i--)
    {
        reversed[j++] = input[i];
    }
    return new string(reversed);
}
string revv = ReverseString("xerexi");
Console.WriteLine(revv);

string ReverseStringg(string str) //Recursion
{
    if(str.Length <= 1) return str;
    return str[str.Length - 1] + ReverseStringg(str.Substring(0, str.Length - 1)); //Recursive call
}
Console.WriteLine(ReverseStringg("qwerty"));

bool IsStringPalindrome(string input) //Fetch indices(left and right) 0, 4
{
    int left = 0, right = input.Length - 1;
    while(left < right)
    {
        if (input[left] != input[right]) return false;  
        left++; right--;
    }
    return true;
}
Console.WriteLine(IsStringPalindrome("abha"));

bool IsAnagramChecker(string str1, string str2)
{
    if(str1.Length != str2.Length) return false;
    char[] arr1 = str1.ToCharArray();
    char[] arr2 = str2.ToCharArray();
    
    Array.Sort(arr1);
    Array.Sort(arr2);
    for(int i = 0; i< arr1.Length; i++)
    {
        if (arr1[i] != arr2[i]) return false;
    }
    return true;
}
Console.WriteLine(IsAnagramChecker("aka", "kaa"));

bool IsAnagramCheckerOptimal(string s1, string s2)
{
    if(s1.Length != s2.Length)
        return false;
    Dictionary<char, int> frequency = new();
    foreach(char c in s1) //count characters in s1 
    {
        if (frequency.ContainsKey(c)) //if freq contains the char already, then increment it.
        {
            frequency[c]++;
        }
        frequency[c] = 1; //initialize each char to 1
    }
    foreach(char c in s2)
    {
        if (!frequency.ContainsKey(c))
            return false;
        frequency[c]--;
        if (frequency[c] < 0) return false;
    }
    return true;
}
IsAnagramCheckerOptimal("triangle", "integral");