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

int RemoveDuplicatesNaive(int[] arr) 
{
    List<int> unique = new();
    foreach(var item in arr)
    {
        if(!unique.Contains(item))
            unique.Add(item);
    }
    for (int i = 0; i < unique.Count; i++)
        arr[i] = unique[i];
    return unique.Count;
}

Console.WriteLine(RemoveDuplicatesNaive([1, 2, 2, 3, 3, 4])); 

int RemoveDuplicatesOptimal(int[] arr) // 1, 2, 2, 3, 3, 4 -> Two Pointers approach
{
    if (arr.Length == 0) return 0;
    int i = 0;
    for(int j = 1; j < arr.Length; j++)
    {
        if (arr[j] != arr[i])
        {
            i++;
            arr[i] =arr[j];
        }
    }
    return i + 1;
}
Console.WriteLine(RemoveDuplicatesOptimal([1, 2, 2, 3, 3, 4, 4, 4, 5]));

void LeftRotateByOne(int[] arr)
{
    int temp = arr[0];
    for(int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    arr[arr.Length - 1] = temp;
    Console.WriteLine(arr);
}
LeftRotateByOne([1, 2, 3, 4, 5]);


//✅ Question 13: Left Rotate Array by D Positions

void LeftRotateByDPositionsNaive(int[] arr, int d)
{
    for(int i = 0; i < d; i++)
    {
        LeftRotateByOne(arr); 
    }
    Console.WriteLine(arr);
}
LeftRotateByDPositionsNaive([1, 2, 3, 4, 5], 3);

//⚡ Optimal Approach(Reverse Method):
//Reverse first D elements.
//Reverse remaining n-D elements.
//Reverse the entire array.
void Reverse(int[] arr, int start, int end)
{
    while (start < end)
    {
        (arr[start], arr[end]) = (arr[end], arr[start]);
        start++; end--;
    }
}

void LeftRotateByDOptimal(int[] arr, int d)
{
    int n = arr.Length;
    d %= n;

    Reverse(arr, 0, d - 1);
    Reverse(arr, d, n - 1);
    Reverse(arr, 0, n - 1);
}
LeftRotateByDOptimal([1, 2, 3, 4, 5], 3);

//✅ Question 14: Maximum Sum Subarray of Size K

//✅ Question 16: Compute Prefix Sum of an Array
//❓ Given an array, create a new array where each element at index i is the sum of elements from 0 to i of the original array.

//Example:
//Input: [2, 4, 6, 8]
//Output: [2, 6, 12, 20]

int[] PrefixSumNaive(int[] nums) // 2, 4, 6, 8
{
    int[] prefixSum = new int[nums.Length];
    for(int i = 0; i < nums.Length; i++)
    {
        int sum = 0;
        for(int j = 0; j <=i; j++)
        {
            sum += nums[j];
        }
        prefixSum[i] = sum;
    }
    return prefixSum;
}
PrefixSumNaive([2, 4, 6, 8]);

int[] PrefixSumOptimal(int[] nums)
{
    int[] prefixSum = new int[nums.Length];
    prefixSum[0] = nums[0];
    for(int i = 1; i < nums.Length; i++)
    {
        prefixSum[i] = prefixSum[i - 1] + nums[i];
    }
    return prefixSum;
}
PrefixSumOptimal([2, 4, 6, 8]);

//✅ Question 17: Move All Zeros to the End (Maintain Order)
//❓ Move all zeros in the array to the end, while keeping the order of non-zero elements the same.

//Example:
//Input: [1, 0, 2, 0, 3]
//Output: [1, 2, 3, 0, 0]

//🔁 Naive Approach — Step-by-Step:
//Create a new array or list.

//First insert all non-zero elements.

//Then add zeroes at the end.

int[] MoveAllZeroesNaive(int[] arr)
{
    List<int> result = new();
    int zeroesCount = 0;
    foreach(var item in arr)
    {
        if(item != 0)
        {
            result.Add(item);
        }
        else
        {
            zeroesCount++;
        }
    }
    while(zeroesCount > 0)
    {
        result.Add(0);
        zeroesCount--;
    }
    return result.ToArray();
}
MoveAllZeroesNaive([1, 0, 3, 4, 0, 5, 0, 0, 8]);

//⚡ Optimal Approach — Step-by-Step (In-place):
//Use a pointer j to track the next position to insert a non-zero.

//Loop through the array:

//If the current element is non-zero, assign it to arr[j++]

//After placing non-zero elements, fill the rest with zeros.
void MoveAllZeroesOptimal(int[] arr)
{
    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
           arr[j++] = arr[i];
    }
    while(j < arr.Length)
        arr[j++] = 0;
}
MoveAllZeroesOptimal([1, 0, 3, 4, 0, 5, 0, 0, 8]);

//✅ Question 19: Two Sum Problem
//❓ Given an array and a target, return indices of two elements that add up to the target.

(int, int) TwoSumNaive(int[] arr, int target)
{ 
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] + arr[j] == target) return (i, j);
        }
    }
    return (-1, -1);
}
Console.WriteLine(TwoSumNaive([2, 1, 4, 5, 9], 23));

//TWO POINTERS QUESTIONS
//✅ Problem 1: Check if Array Has a Pair with Given Sum (Sorted Array)
//❓ Problem
//Given a sorted array and a target sum, return true if a pair exists such that arr[i] + arr[j] == target.

//Example:
//Input: arr = [1, 2, 3, 4, 6], target = 7
//Output: true (1 + 6 or 3 + 4)


bool HasPairWithSumNaive(int[] arr, int target) //[1, 2, 3, 4, 6]
{
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] + arr[j] == target)
                return true;
        }
    }
    return false;
}
Console.WriteLine(HasPairWithSumNaive([1, 2, 3, 4, 6], 12));

//⚡ Two Pointers Approach
//Step-by-Step:
//Use two pointers left = 0, right = arr.Length - 1.
//While left < right:
//Compute sum = arr[left] + arr[right]
//If sum == target: return true
//If sum<target: move left++
//If sum > target: move right--

bool HasPairWithSumOptimal(int[] arr, int target) //[1, 2, 3, 4, 6], target = 8  (Sorted Array)
{
    int left = 0, right = arr.Length - 1;
    while (left < right)     //✅ Time: O(n), Space: O(1)
    {
        if (arr[left] + arr[right] == target) return true;
        else if (arr[left] + arr[right] > target) right--;
        else if (arr[left] + arr[right] < target) left++;
    }
    return false;
}
Console.WriteLine(HasPairWithSumOptimal([1, 2, 3, 4, 6], 23));

//✅ Problem 2: Reverse an Array In-Place
//❓ Problem
//Reverse the array without using extra space.

//Example:
//Input: [1, 2, 3, 4] → Output: [4, 3, 2, 1]

//⚡ Two Pointers Approach
//Step-by-Step:
//Set left = 0, right = arr.Length - 1.

//While left < right:

//Swap arr[left] and arr[right].

//Increment left, decrement right.

void ReverseArrayInPlaceOptimal(int[] arr) //[1, 2, 3, 4] -> [4, 3, 2, 1]
{
    int left = 0, right = arr.Length - 1;
    while(left < right) //✅ Time: O(n/2), Space: O(1)
    {
        (arr[left], arr[right]) = (arr[right], arr[left]);
        left++;
        right--;
    }
}
ReverseArrayInPlaceOptimal([1, 2, 5, 3, 4]);

//✅ Problem 4: Merge Two Sorted Arrays
//❓ Problem
//Given two sorted arrays, merge them into one sorted array.

//Example:
//a = [1, 3, 5], b = [2, 4, 6] → [1,2,3,4,5,6]

int[] MergeSortedArraysNaive(int[] arr1, int[] arr2)
{
    int[] combined = arr1.Concat(arr2).ToArray();
    Array.Sort(combined);
    return combined;
}
Console.WriteLine(MergeSortedArraysNaive([1, 3, 5], [2, 4, 6]));

int[] MergeSortedArrayOptimal(int[] a, int[] b)
{
    List<int> combined = new();
    int i = 0, j = 0;
    while(i < a.Length && j < b.Length)
    {
        if (a[i] < b[j])
            combined.Add(a[i++]);
        else
            combined.Add(b[j++]);
    }
    while(i < a.Length)
        combined.Add(a[i++]);
    while(j < b.Length)
        combined.Add(b[j++]);
    return combined.ToArray();
}
MergeSortedArrayOptimal([1, 3, 5], [1, 2, 3, 4,5]);

//✅ Problem 5: Remove Duplicates from Sorted Array
//❓ Problem
//Remove duplicates in-place from a sorted array and return new length.

//✅ Problem 6: Move Negative Elements to the Beginning and Positive to the End (Maintain Order Not Required)

//❓ Problem
//Given an array with both negative and positive numbers, rearrange the array so that all negative numbers come before positives. Order does not matter.

//Example:
//Input: [1, -2, 3, -4, -5, 6]
//Output: [-5, -4, -2, 3, 1, 6] (any order with negatives first)
void ReArrangeNaive(int[] arr)
{
    List<int> negatives = new();
    List<int> positives = new();
    foreach(int item in arr)
    {
        if(item < 0) negatives.Add(item);
        else positives.Add(item);
    }
    int i = 0;
    foreach(int num in negatives) arr[i++] = num;
    foreach(int num in positives) arr[i++] = num;
}
ReArrangeNaive([1, -2, 3, -4, -5, 6]);

void ReArrangeOptimal(int[] arr) //[1, -2, 3, -4, 7, -4, -5, 6]
{
    int left = 0, right = arr.Length - 1;
    while(left < right)
    {
        if (arr[left] < 0)
            left++;
        else if (arr[right] >= 0)
            right--;
        else
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            left++;
            right--;
        }
    }
}
ReArrangeOptimal([1, -2, 3, -4, 7, -4, -5, 6]);

//✅ Problem 7: Container With Most Water
//❓ Problem
//You are given n non-negative integers representing vertical lines. Find two lines that together with the x-axis form a container that holds the maximum water.

//Example:
//Input: [1, 8, 6, 2, 5, 4, 8, 3, 7]
//Output: 49

//🔁 Naive Approach
//Step-by-Step:
//Try all pairs (i, j) where i < j.

//Area = min(height[i], height[j]) *(j - i)

//Track the max area.

int MaxAreaNaive(int[] height)
{
    int maxArea = 0;
    for(int i = 0; i < height.Length; i++)
    {
        for(int j = i + 1; j < height.Length; j++)
        {
            int area = Math.Min(height[i], height[j]) * (j - i); //length * breadth OR side * side length = number; breadth = difference between indices
            maxArea = Math.Max(maxArea, area);
        }
    }
    return maxArea;
}
MaxAreaNaive([1, 8, 6, 2, 5, 4, 8, 3, 7]);

//⚡ Two Pointers Approach
//Step-by-Step:
//Use left = 0, right = n - 1.

//At each step, calculate area = min(height[left], height[right]) *(right - left).

//Move the pointer pointing to the shorter line (to possibly find a taller one).

int MaxAreaOptimal(int[] height) //[1, 8, 6, 2, 5, 4, 8, 3, 7]
{
    int left = 0, right = height.Length - 1;
    int maxArea = 0;
    while(left < right)
    {
        int area = Math.Min(height[left], height[right]) * (right - left);
        maxArea = Math.Max(area, maxArea);

        if (height[left] < height[right])
            left++;
        else
            right--;
    }
    return maxArea;
}
Console.WriteLine(MaxAreaOptimal([1, 8, 6, 2, 5, 4, 8, 3, 7]));