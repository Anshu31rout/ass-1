using System;

public class BinarySearch
{
    public int PerformBinarySearch(int[] array, int target)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array), "The array cannot be null.");
        if (array.Length == 0)
            throw new ArgumentException("The array cannot be empty.", nameof(array));

        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == target)
                return mid;
            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}

public class Program
{
    public static void Main()
    {
        var binarySearch = new BinarySearch();
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 5;
        int result = binarySearch.PerformBinarySearch(sortedArray, target);
        Console.WriteLine(result != -1 ? $"Target {target} found at index: {result}" : $"Target {target} not found in the array.");
    }
}
