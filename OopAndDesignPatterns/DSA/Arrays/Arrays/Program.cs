//✅ Question 1: Find the Maximum Element in an Array
int FindMaxNum(int[] arr)
{
    int max = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

Console.WriteLine(FindMaxNum([1, 2, 3, 4, 5]));

//✅ Question 2: Find the Minimum Element in an Array
int FindMinNum(int[] arr)
{
    int min = arr[0];
    for(int i = 0;i < arr.Length;i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
Console.WriteLine(FindMinNum([1, 2, 4, 6, 0]));

//✅ Question 3: Find the Sum of All Elements
int FindSum(int[] arr)
{
    int sum = 0;
    for(int i = 0;i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}
Console.WriteLine(FindSum([1, 2, 3, 4, 5]));
int FindSumLinq(int[] arr)
{
    return arr.Sum();
}
Console.WriteLine(FindSumLinq([1, 2, 3]));

//✅ Question 4: Check if Array is Sorted (Ascending Order)
bool IsSorted(int[] arr) //3, 2, 3, 4,
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > arr[i + 1]) return false;
    }
    return true;
}
Console.WriteLine(IsSorted([1, 2, 3, 2]));

//✅ Question 5: Reverse the Array
int[] ReverseArray(int[] arr)
{
    int[] ReversedArray = new int[arr.Length];
    int j = 0;
    for(int i = arr.Length - 1; i >= 0; i--)
    {
        ReversedArray[j] = arr[i];
        j++;
    }
    return ReversedArray;
}
Console.WriteLine(ReverseArray([1, 2, 3, 4, 5]));

//⚡ Optimal Approach:
//In - place reversal using two pointers. Swap left most and right most and move inside from left and right simullateously.
int[] ReverseArrayOptimal(int[] arr) //1, 2, 3, 4, 5 
{
    int left = 0, right = arr.Length - 1;
    while (left < right)
    {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        left++;
        right--;
    }
    return arr;
}
Console.WriteLine(ReverseArrayOptimal([1, 2, 3, 4, 5, 6]));

//✅ Question 6: Search for an Element in an Array
bool LinearSearch(int[] arr, int x) // 3, 6, 1, 4, 9 ; x = 4
{
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x) return true;
    }
    return false;
}
Console.WriteLine(LinearSearch([3, 6, 1, 4, 9], 4));

//If array is sorted, use Binary Search.
bool BinarySearch(int[] arr, int x) //Sorted Array 1, 2, 3, 4, 5; x = 4
{
    int left = 0; int right = arr.Length - 1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (arr[mid] == x) return true;
        else if (arr[mid] > x) right = mid - 1;
        else if (arr[mid] < x) left = mid + 1;
    }
    return false;
}
Console.WriteLine(BinarySearch([1, 2, 3, 4, 5], 4));

//✅ Question 7: Count Frequency of Each Element
void CountFrequencyNaive(int[] arr) //1 , 2 , 2, 3, 3, 4
{
    for(int i = 0;i < arr.Length;i++)
    {
        int count = 0;
        for(int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == arr[i]) count++;
        }
        Console.WriteLine($"{arr[i]} appears {count} times");
    }
}
CountFrequencyNaive([1, 2, 2, 3, 3, 4]);

void CountFrequencyOptimal(int[] arr)
{
    Dictionary<int, int> freq = new();
    foreach(int num in arr)
    {
        if(freq.ContainsKey(num)) freq[num]++;
        else freq[num] = 1;
    }
    foreach(var kv  in freq)
    {
        Console.WriteLine($"{kv.Key} appears {kv.Value} times");
    }
}
CountFrequencyOptimal([1, 2, 3, 3, 4, 4]);

int FirstRepeating(int[] arr) //Add items to frequency - O(N) -> Search in frequency -> O(n) -> TOtal - O(n) + O(n) 
{
    Dictionary<int, int> freq = new();
    foreach(var num in arr)
    {
        if(freq.ContainsKey(num)) freq[num]++;
        else freq[num] = 1;
    }
    foreach (var kv in freq)
    {
        if (kv.Value > 1) return kv.Key;
    }
    return 0;
}
Console.WriteLine(FirstRepeating([1, 2, 3, 3, 4, 4, 5, 5, 6]));

int FirstRepeatingUsingHashset(int[] arr) //Just wow - Add items to hashset if doesn't exist. And keep adding until the element is not found. Worst case - O(n)
{
    HashSet<int> seen = new();
    for(int i = 0; i < arr.Length; i++)
    {
        if (seen.Contains(arr[i])) return arr[i];
        else seen.Add(arr[i]);
    }
    return -1;
}
Console.WriteLine(FirstRepeatingUsingHashset([1, 2, 3, 3, 4, 4, 5]));

//✅ Question 9: Find the First Non-Repeating Element
int FirstNonRepeatingNumberOptimal(int[] arr) // 1, 1, 2, 3, 4
{
    Dictionary<int, int> freq = new();
    foreach(var num in arr)
    {
        if (freq.ContainsKey(num)) freq[num]++;
        else freq[num] = 1;
    }
    foreach(var kv in freq)
    {
        if (kv.Value == 1) return kv.Key;
    }
    return -1;
}
Console.WriteLine(FirstNonRepeatingNumberOptimal([1, 1, 2, 2, 3, 3, 4]));

//✅ Question 10: Find the Largest Three Elements in Array
int[] FindLargestThree(int[] arr)
{
    var unique = arr.Distinct().ToArray();
    Array.Sort(unique);
    int n = unique.Length;
    return new int[] { unique[n-1], unique[n - 2], unique[n - 3] };
}
Console.WriteLine(FindLargestThree([3, 4, 1, 10, 12]));
