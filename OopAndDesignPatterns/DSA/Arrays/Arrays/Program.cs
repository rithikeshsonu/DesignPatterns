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
    while (left < right)
    {
        int mid = (left + right) / 2;
        if (arr[mid] == x) return true;
        if (arr[mid] > x) right = mid - 1;
        else if (arr[mid] < x) left = mid + 1;
    }
    return false;
}
Console.WriteLine(BinarySearch([1, 2, 3, 4, 5], 2));