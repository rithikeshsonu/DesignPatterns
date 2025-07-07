using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

void IsNumberPalindrome(int num) //121
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
IsNumberPalindrome(121);

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
Console.WriteLine(ReverseString("xerexi"));

string ReverseStringUsingRecursion(string str) //Recursion
{
    if(str.Length <= 1) return str;
    return str[str.Length - 1] + ReverseStringUsingRecursion(str.Substring(0, str.Length - 1)); //Recursive call
}
Console.WriteLine(ReverseStringUsingRecursion("qwerty"));

//✅ Question #11: Check if a String is a Palindrome
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
        else
        {
            frequency[c] = 1; //initialize each char to 1
        }
    }
    foreach(char c in s2) //Now that we have frequency array. Subtract each char's count if found in s2.
    {
        if (!frequency.ContainsKey(c))
            return false;
        frequency[c]--;
        if (frequency[c] < 0) return false;
    }
    return true;
}
Console.WriteLine(IsAnagramCheckerOptimal("akak", "kaaa"));

string RemoveDuplicatesNaive(string str)
{
    string result = ""; //O(n) Space complexity
    foreach(char c in str)
    {
        if (!result.Contains(c)) //O(n^2) Time complexity as the char is scanned in whole result string
        {
            result += c;
        }
    }
    return result;
}
Console.WriteLine(RemoveDuplicatesNaive("programming"));

string RemoveDuplicatesOptimal(string str)
{
    HashSet<char> seen = new(); //Add each character to hashset if the character is not present in hashset.
    StringBuilder sb = new(); //O(n) Space complexity
    foreach(char c in str) 
    {
        if (!seen.Contains(c)) //O(n) TC 
        {
            seen.Add(c);
            sb.Append(c);
        }
        //seen.Add(c);  //Even if you add this line, the character will not go inside hashset because hashset only contains unique chars
    }
    return sb.ToString();
}
Console.WriteLine(RemoveDuplicatesOptimal("programming"));

char FirstNonRepeatingNaive(string str) //aabcc
{
    for(int i = 0; i < str.Length; i++) //For each character loop through whole string and count the occurences of char.
    {
        int count = 0;
        for(int j = 0; j < str.Length; j++) //O(n^2) Time complexity
        {
            if (str[i] == str[j])
            {
                count++;
            }
        }
        if(count == 1)
        {
            return str[i];
        }
    }
    return '\0';
}
Console.WriteLine(FirstNonRepeatingNaive("aabbcc"));

char FirstNonRepeatingOptimal(string str) //Total Time complexity -> O(n) + O(n) = O(2n) 
{
    Dictionary<char, int> freq = new(); //Build a frequency dictionary with counts of each char
    foreach(char c in str) //O9n) time complexity to build a frequency array
    {
        if (freq.ContainsKey(c))
        {
            freq[c]++;
        }
        else
        {
            freq[c] = 1;
        }
    } //Now we have count of each char in key value pairs
    foreach(char c in str) //O(n) Time complexity to check in whole string 
    {
        if (freq[c] == 1)
            return c;
    }
    return '\0';
}

Console.WriteLine(FirstNonRepeatingOptimal("aabcc"));


//✅ Check if Two Strings Are Rotations of Each Other
bool IsRotationNaive(string s1, string s2) //abcd, cdab
{
    if (s1.Length != s2.Length)
        return false;
    for(int i = 0; i < s1.Length; i++)
    {
        string rotated = s1.Substring(i) + s1.Substring(0, i); //First iteration string rotated = "abcd", second iteration - rotated = "bcd" + "a" third iteration rotated = "cd" + "ab"
        if(rotated == s2) return true;
    }
    return false;
}
Console.WriteLine(IsRotationNaive("abcd", "cdab"));

bool IsRotationOptimal(string s1, string s2) //abcd, cdab  -> If s2 is a rotation of s1, then it will always be a substring of s1 + s1 cdab will be present in //abcdabcd
{
    if(s1.Length != s2.Length) return false;
    string concatenated = s1 + s1;
    return concatenated.Contains(s2);
}

Console.WriteLine(IsRotationOptimal("abcd", "cdab"));

void CountVowelsAndConsonentsNaive(string str) //program
{
    int vowels = 0, consonants = 0;
    foreach(char c in str.ToLowerInvariant())
    {
        if (char.IsLetter(c))
        {
            if("aeiou".Contains(c))
                vowels++;
            else 
                consonants++;
        }
    }
    Console.WriteLine($"Vowels count: {vowels}");
    Console.WriteLine($"Consonants count: {consonants}");
}
CountVowelsAndConsonentsNaive("program");

//✅ Find the Longest Word in a Sentence

string FindLongestWordNaive(string sentence)
{
    string[] words = sentence.Split(' ');
    string longest = "";
    foreach(string word in words)
    {
        if (word.Length > longest.Length)
        {
            longest = word;   
        }
    }
    return longest;
}
Console.WriteLine(FindLongestWordNaive("The quick brown fox jumps over the lazy dog"));

string FindLongestWordClean(string sentence) //Remove special chars, punctuations, etc.,
{
    string[] words = sentence.Split(' ');
    string longest = "";
    foreach(string word in words)
    {
        string cleaned = Regex.Replace(word, @"^\W+|\W+$", ""); //Remove special chars, punctuations, etc.,
        if(cleaned.Length > longest.Length)
        {
            longest = cleaned;
        }
    }
    return longest;
}
Console.WriteLine(FindLongestWordClean("The quick, brown fox! jumped over the lazy... dog."));

int StrStrNaive(string haystack, string needle) //"hello", "ll"
{
    if (needle == "")
        return 0;
    for(int i = 0; i <= haystack.Length - needle.Length; i++) //0 to 3 indices
    {
        int j = 0; 
        while(j < needle.Length && haystack[i+j] == needle[j]) //First check 'l' from ll exists in "hello". then check second 'l' from 'll' in 'hello'
        {
            j++;
        }
        if(j == needle.Length) return i;
    }
    return -1;
}
Console.WriteLine(StrStrNaive("hello", "ll"));

//Given a string, compress it using the counts of repeated characters.
//Return the compressed string only if it is shorter than the original. Otherwise, return the original.
string CompressString(string str) //aabbbccddd -> a2b3c2d3
{
    if (string.IsNullOrEmpty(str))
        return str;
    StringBuilder compressed = new();
    int count = 1;
    for(int i = 1; i < str.Length; i++)
    {
        if (str[i] == str[i - 1])
            count++;
        else
        {
            compressed.Append(str[i-1]);
            compressed.Append(count);
            count = 1;
        }
    }
    compressed.Append(str[str.Length-1]);
    compressed.Append(count);
    string result = compressed.ToString();
    return result.Length < str.Length ? result : str;
}

Console.WriteLine(CompressString("aabbbccccdda"));


//✅ Question #12: Remove All Whitespaces from a String
//Input: "  Hello   World  "
//Output: "HelloWorld"

//Input: "  A B\tC\nD E "
//Output: "ABCDE"
//💡 Idea:
//Loop through each character in the string

//Use char.IsWhiteSpace() to detect and skip whitespace

//Build a new string without them

string RemoveWhiteSpaces(string str)
{
    StringBuilder sb = new();
    foreach(char c in str)
    {
        if (char.IsWhiteSpace(c))
        {
            continue;
        }
        else
        {
            sb.Append(c);
        }
    }
    return sb.ToString();
}
Console.WriteLine(RemoveWhiteSpaces("  A B\tC\nD E "));

//✅ Question #13: Find the Most Frequent Character in a String
//Input: "hello"
//Output: 'l'(appears 2 times)

//Input: "aabbbbcc"
//Output: 'b'

//Input: "xyz"
//Output: any of 'x', 'y', or 'z' (all equal freq)

//💡 Idea:
//Loop through each character

//For each one, count how many times it occurs (by scanning full string again)

//Track the max

char MostFequeuentCharNaive(string str) //aabc
{
    char maxChar = '\0';
    int maxCount = 0;
    for(int i = 0; i < str.Length; i++)
    {
        char current = str[i]; 
        int count = 0;
        for(int j = 0; j < str.Length; j++)
        {
            if(current == str[j])
                count++;
        }
        if(count > maxCount)
        {
            maxChar = current;
            maxCount = count;
        }
    }
    return maxChar;
}
Console.WriteLine(MostFequeuentCharNaive("aabbbbcc"));

char MostFrequentCharOptimal(string str) //"aabbbbcc"
{
    if (string.IsNullOrEmpty(str)) 
        return '\0';
    Dictionary<char, int> freq = new();
    foreach (char c in str)
    {
        if (freq.ContainsKey(c))
            freq[c]++;
        else
            freq[c] = 1;
    }
    char maxChar = '\0';
    int maxCount = 0;
    foreach(var pair in freq)
    {
        if(pair.Value > maxCount)
        {
            maxChar = pair.Key; 
            maxCount = pair.Value;
        }
    }
    return maxChar;
}

Console.WriteLine(MostFrequentCharOptimal("aabbbbccc"));

List<List<string>> GroupAnagramsNaive(string[] words) //["eat", "tea", "tan", "ate", "nat", "bat"] 
{
    bool[] visited = new bool[words.Length];
    var result = new List<List<string>>();
    for(int i = 0; i < words.Length; i++)
    {
        if (visited[i]) continue;
        var group = new List<string>() { words[i] };
        visited[i] = true;
        for(int j = i + 1; j < words.Length; j++)
        {
            if (!visited[j] && IsAnagramChecker(words[i], words[j]))
            {
                group.Add(words[j]);
                visited[j] = true;
            }
        }
        result.Add(group);
    }
    return result;
}
Console.WriteLine(GroupAnagramsNaive(["eat", "tea", "tan", "ate", "nat", "bat"]));

bool AreStringsPermutationsNaive(string s1, string s2) //abc, bca
{
    if(s1.Length != s2.Length) return false;
    char[] c1 = s1.ToCharArray();
    char[] c2 = s2.ToCharArray();
    Array.Sort(c1);
    Array.Sort(c2);
    for(int i = 0;i < c1.Length; i++)
    {
        if (c1[i] != c2[i]) return false;
    }
    return true;
}
Console.WriteLine(AreStringsPermutationsNaive("abc", "bca"));

bool AreStringsPermutationsOptimal(string s1, string s2)
{
    if(s1.Length != s2.Length) return false;
    int[] freq = new int[256];//Hash Array //ASCII
    foreach (char c in s1)
        freq[c]++;
    foreach(char c in s2)
    {
        freq[c]--;
        if (freq[c] < 0) return false;
    }
    return true;
}
Console.WriteLine(AreStringsPermutationsOptimal("abcg", "bcat"));


//✅ Question #16: Check if Two Strings Are One Edit Apart
//🔍 Problem Statement:
//Two strings are one edit away if you can:

//Insert one character

//Remove one character

//Replace one character

//to make them equal.
//Input: s1 = "pale", s2 = "ple"   → true(remove 'a')
//Input: s1 = "pales", s2 = "pale" → true(remove 's')
//Input: s1 = "pale", s2 = "bale"  → true(replace 'p' with 'b')
//Input: s1 = "pale", s2 = "bake"  → false(more than one edit)
bool IsOneEditAwayNaive(string s1, string s2)
{
    if(s1 == s2) return true;
    if(Math.Abs(s1.Length - s2.Length) > 1) 
        return false;
    //If length matches
    if(s1.Length == s2.Length)
    {
        int mismatches = 0;
        for(int i = 0; i < s1.Length ; i++)
        {
            if (s1[i] != s2[i]) 
                mismatches++;
        }
        return mismatches == 1;
    }
    //If lengths doesn't match
    string longer = s1.Length > s2.Length ? s1 : s2;
    string shorter = s1.Length > s2.Length ? s2 : s1;
    for(int i = 0; i < longer.Length ; i++)
    {
        string modified = longer.Remove(i, 1); //
        if(modified == shorter) 
            return true;
    }
    return false;
}
Console.WriteLine(IsOneEditAwayNaive("pale", "pal"));