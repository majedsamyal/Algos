using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Array.update1
{
    public class ArrayProblems
    {
        /// <summary>
        /// Rotate array one by one
        /// Time Complexcity:O(N*d), where d is number of rotations
        /// Space Complexcity:O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static int[] LeftRotateArray(int[] arr, int count)
        {
            // [1,2,3,4,5,6,7]
            // rotate by left 1 = [2,3,4,5,6,7,1]   
            // rotate by left 2 = [3,4,5,6,7,1,2]   
            int rotate = 0;
            while (rotate <= count - 1)
            {
                int temp1 = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[arr.Length - 1] = temp1;
                rotate++;
            }

            return arr;
        }

        /// <summary>
        /// Use extra space and rotate array in one go
        /// Time Complexcity:O(N)
        /// Space Complecity:O(d), where d is number of rotations
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static int[] LeftRotateArrayUsingExtraSpace(int[] arr, int count)
        {
            // store partial array till number of rotation into temp array
            int[] tempArr = new int[count];
            for (int i = 0; i < count; i++)
            {
                tempArr[i] = arr[i];
            }

            for (int i = count; i < arr.Length; i++)
            {
                arr[i - count] = arr[i];
            }

            int index = arr.Length - count;
            for (int i = 0; i < tempArr.Length; i++)
            {
                arr[index++] = tempArr[i];
            }

            return arr;
        }

        /// <summary>
        /// Rotate array one by one
        /// Time Complexcity:O(N*d), where d is number of rotations
        /// Space Complexcity:O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static int[] RightRotateArray(int[] arr, int count)
        {
            // [1,2,3,4,5,6,7]          
            // rotate by right 1 = [7,1,2,3,4,5,6]
            int rotation = count - 1;
            int temp = 0;
            while (rotation >= 0)
            {
                temp = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = temp;
                rotation--;
            }
            return arr;
        }

        /// <summary>
        /// Using XOR, we will get the missing element from range
        /// Time Complexcity:O(N), using loop to do XOR of all elements
        /// Space Complexcity:O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindMissingElementUsingXOR(int[] arr)
        {
            //int[] a = {1, 2, 4, 5, 6};
            int xorArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                xorArr = xorArr ^ arr[i];
            }

            for (int i = 1; i < arr.Length + 1; i++)
            {
                xorArr = xorArr ^ i;
            }

            return xorArr;
        }

        /// <summary>
        /// Take third array of space arr1.Length + arr2.Length, using while loop compare and added elements to this new array
        /// Time Complexcity:O(N)
        /// Space Complexcity:O(N + M), using extra space
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] MergeTwoSortedArrayUsingExtraSpace(int[] arr1, int[] arr2)
        {
            //input: arr1[] = { 1, 3, 4, 5}, arr2[] = {2, 4, 6, 8} 
            // size of result array
            int[] result = new int[arr1.Length + arr2.Length];

            int i = 0;
            int j = 0;
            int k = 0; // result array index

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                }
                else
                {
                    result[k] = arr2[j];
                    j++;
                }
                // always increament
                k++;
            }

            while (i < arr1.Length)
            {
                result[k] = arr1[i];
                k++;
                i++;
            }
            while (j < arr2.Length)
            {
                result[k] = arr2[j];
                k++;
                j++;
            }

            return result;
        }

        /// <summary>
        /// Initialize variables and compare two array, update first array
        /// Time Complexcity:O(N)
        /// Space Complexcity:O(1), as given first array has extra space already
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] MergeTwoSortedArrayIntoOne(int[] arr1, int[] arr2)
        {
            // leetcode
            // assume arr1 has space for arr2 elements
            // return sorted arr1
            // Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3

            int i = (arr1.Length - arr2.Length) - 1;
            int j = arr2.Length - 1;
            int k;

            for (k = arr1.Length - 1; k >= arr2.Length; k--)
            {
                if (arr2[j] > arr1[i])
                {
                    arr1[k] = arr2[j];
                    j--;
                }
                else
                {
                    arr1[k] = arr1[i];
                    arr1[i] = arr2[j];
                    i--;
                }
            }

            // nums1 = [1,2,3], m = 3, nums2 = [2,5,6], n = 3
            return arr1;
        }

        /// <summary>
        /// Find using XOR logic operator, assuming there will be always max two occurance (any even number) of other intergers 
        /// Time Complexcity:O(N), using loop to traverse the array
        /// Space Complexcity:O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindElementAppearsOnceUsingXOR(int[] arr)
        {
            // arr[] = {1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8}

            int i = 0;
            int result = 0;
            while (i < arr.Length)
            {
                result = result ^ arr[i];
                i++;
            }

            return result;
        }

        /// <summary>
        /// Using simple while loop, increment the index by 2 each time
        /// Time Complexcity:O(N)
        /// Space Complexcity:O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindElementAppearsOnceUsingLoop(int[] arr)
        {
            // arr[] = {1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8}
            int i = 0;

            while (i < arr.Length)
            {
                if (arr[i] != arr[i + 1])
                {
                    return arr[i];
                }
                i += 2;
            }

            return -1;
        }

        /// <summary>
        /// Using Binary Search, this array has one property the first occurance exists at even and second at odd if target element not found in a range.
        /// Time Complexcity:O(log N)
        /// Space Complexcity:O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void FindElementAppearsOnceUsingBinarySearch(int[] arr, int low, int high)
        {
            // arr[] = {1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8}

            if (low > high)
                return;
            if (low == high)
            {
                Console.WriteLine(arr[low]);
                return;

            }

            int mid = (low + high) / 2;

            if (mid % 2 == 0) // even
            {
                if (arr[mid] == arr[mid + 1])
                {
                    // element in second portion of array
                    FindElementAppearsOnceUsingBinarySearch(arr, mid + 1, high);
                }
                else
                {
                    // element in first portion of array
                    FindElementAppearsOnceUsingBinarySearch(arr, low, mid);
                }
            }

            else if (mid % 2 == 1) //odd
            {
                if (arr[mid] == arr[mid - 1])
                {
                    // element in second portion of array
                    FindElementAppearsOnceUsingBinarySearch(arr, mid + 1, high);
                }
                else
                {
                    // element in first portion of array
                    FindElementAppearsOnceUsingBinarySearch(arr, low, mid - 1);
                }
            }
        }


        public static int FindItemUsingBinarySearch(int[] arr, int item, int low, int high)
        {
            if (low > high)
            {
                // base case
                // item not found
                return -1;
            }
            int mid = low + ((high - low) / 2);

            if (arr[mid] == item)
            {
                return mid;
            }
            else if (item < arr[mid])
            {
                return FindItemUsingBinarySearch(arr, item, low, mid - 1);
            }
            else
            {
                return FindItemUsingBinarySearch(arr, item, mid + 1, high);
            }
        }

        public static void MergeSort(int[] arr, int[] auxArr, int low, int high)
        {
            // base case
            if (low == high)
            {
                return;
            }
            int mid = low + ((high - low) / 2);
            MergeSort(arr, auxArr, low, mid); // left sides of each sub partitions
            MergeSort(arr, auxArr, mid + 1, high); // right sides of each partitions

            // call merge method
            Merge(arr, auxArr, low, mid, high);
        }

        private static void Merge(int[] arr, int[] aux, int low, int mid, int high)
        {
            int k = low, i = low, j = mid + 1;

            while (i <= mid && j <= high)
            {
                if (arr[i] <= arr[j])
                {
                    aux[k++] = arr[i++];
                }
                else
                {
                    aux[k++] = arr[j++];
                }
            }
            while (i <= mid)
            {
                aux[k++] = arr[i++];
            }

            while (j <= high)
            {
                aux[k++] = arr[j++];
            }

            for (i = low; i <= high; i++)
            {
                arr[i] = aux[i];
            }
        }

        public static int MaxNumberInIncreasingAndDecreasingArray(int[] arr, int low, int high)
        {
            // {1,3,5,6,9,6,4,2,1,0}

            if (low == high)
            {
                return arr[low];
            }

            int mid = low + ((high - low) / 2);

            if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
            {
                return arr[mid];
            }

            if (arr[mid] > arr[mid - 1] && arr[mid] < arr[mid + 1])
            {
                // ignore left array
                return MaxNumberInIncreasingAndDecreasingArray(arr, mid + 1, high);
            }
            else
            {
                // ignore right array
                return MaxNumberInIncreasingAndDecreasingArray(arr, low, mid - 1);
            }
        }

        public static void SortArrayOf01And2s(int[] arr)
        {
            int start = 0, end = arr.Length - 1, mid = 0, pivot = 1;

            while (mid <= end)
            {
                if (arr[mid] > pivot)
                {
                    // swap mid with j
                    int temp = arr[mid];
                    arr[mid] = arr[end];
                    arr[end] = temp;
                    end--;
                }
                else if (arr[mid] < pivot)
                {
                    // swap mid = i
                    int temp = arr[mid];
                    arr[mid] = arr[start];
                    arr[start] = temp;
                    start++;
                    mid++;
                }
                else
                {
                    mid++;
                }
            }
        }

        public static int JumpGameProblem(int[] arr)
        {
            int a = arr[0], b = arr[0], jump = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    return jump;

                a--;
                b--;
                b = Math.Max(b, arr[i]);

                if (a == 0)
                {
                    jump++;
                    a = b;
                }
            }

            return jump;
        }

        public static int[] FindNextImmediateMaxNumber(int[] arr)
        {
            int i;
            // find element to swap
            for (i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    i--;
                    break;
                }
            }

            // check if we have reached end
            if (i == 0)
            {
                Console.WriteLine("Not possible");
                return null;
            }
            else
            {
                // find next immediate big number 
                int immediateMax = int.MaxValue;
                int j;
                int k = -1;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i] && arr[j] < immediateMax)
                    {
                        k = j;
                        immediateMax = Math.Min(arr[j], immediateMax);
                    }
                }

                // swap i with j 
                int temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;

                // sort array

                System.Array.Sort(arr, i + 1, (arr.Length - 1) - i);
                return arr;
            }
        }

        public static int MaximumPlatformsRequired(int[] arrival, int[] departure)
        {
            // sort bot array
            System.Array.Sort(arrival);
            System.Array.Sort(departure);

            int maxPlatform = 1;
            int platformNeeded = 1;
            int i = 1, j = 0;

            while (i < arrival.Length && j < departure.Length)
            {
                if (arrival[i] <= departure[j])
                {
                    platformNeeded++;
                    i++;
                    if (platformNeeded > maxPlatform)
                    {
                        maxPlatform = platformNeeded;
                    }
                }
                else
                {
                    platformNeeded--;
                    j++;
                }
            }

            return maxPlatform;
        }

        public static void PrintMatrixInSpriralOrder(int[,] arr, int row, int col)
        {
            // n k  1    2   3   4  m
            //      5    6   7   8
            //      9   10  11  12
            // p   13  14  15  16

            int k = 0, m = col - 1, n = 0, p = row - 1;

            int i;
            int j;
            while (true)
            {
                if (k > m || n > p)
                {
                    break;
                }

                i = k;
                for (j = k; j < m; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }

                j = m;
                for (i = n; i < p; i++)
                {
                    Console.WriteLine(arr[i, j]);
                }

                i = p;
                for (j = m; j > k; j--)
                {
                    Console.WriteLine(arr[i, j]);
                }

                j = k;
                for (i = p; i > n; i--)
                {
                    Console.WriteLine(arr[i, j]);
                }

                k++;
                m--;
                n++;
                p--;


            }

        }

        public static void FrequencyOfElements(int[] arr)
        {
            int n = arr.Length;

            // decreament array values by 1 to get the valid index

            for (int i = 0; i < n; i++)
            {
                arr[i] -= 1;
            }

            // increament array elements by length = 7

            for (int i = 0; i < n; i++)
            {
                arr[arr[i] % n] += n;
            }

            // print frequency 

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1 + ":" + arr[i] / n);
            }
        }

        public static void StockBuySellProblem(int[] arr)
        {
            // 98,178,250,300,40,540,690
            int count = 0;
            List<Trade> lstTrades = new List<Trade>();
            Trade trade;
            if (arr.Length == 1)
            {
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                // find local minima

                while ((i < arr.Length - 1) && arr[i + 1] <= arr[i])
                {
                    i++;
                }

                // check if we have reached at the end of array
                if (i == arr.Length - 1)
                {
                    // no trade found
                    break;
                }

                trade = new Trade() { BuyIndex = i++ };

                // find local maxima

                while ((i < arr.Length) && arr[i - 1] <= arr[i])
                {
                    i++;
                }

                trade.SellIndex = i - 1;

                lstTrades.Add(trade);
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine("No trade found");
            }
            else
            {
                for (int i = 0; i < lstTrades.Count; i++)
                {
                    Console.WriteLine($"Buy at index: {lstTrades[i].BuyIndex} and Sell at index: {lstTrades[i].SellIndex}");
                }
            }
        }

        public static void RotateMatrixBy90(int[,] matrix, int n)
        {
            //int[,] mat = {
            //{ 1, 2, 3, 4 },
            //{ 5, 6, 7, 8 },
            //{ 9, 10, 11, 12 },
            //{ 13, 14, 15, 16 }
            //};

            int layers = n / 2;

            for (int i = 0; i < layers; i++)
            {
                for (int j = i; j < n - 1 - i; j++)
                {
                    // store 4
                    int temp = matrix[j, n - 1 - i];

                    // swap 4 with 1
                    matrix[j, n - 1 - i] = matrix[i, j];

                    // swap 1 with 13
                    matrix[i, j] = matrix[n - j - 1, i];

                    // swap 13 with 16
                    matrix[n - j - 1, i] = matrix[n - 1 - i, n - 1 - j];

                    // swap 16 with temp = 4
                    matrix[n - 1 - i, n - 1 - j] = temp;
                }
            }
        }

        private static bool Knows(int[,] matrix, int a, int b)
        {
            return matrix[a, b] == 1;
        }
        public static void FindCelebrity(int[,] matrix, int n)
        {
            int a = 0;
            int b = n - 1;

            while (a < b)
            {
                if (Knows(matrix, a, b))
                {
                    a++;
                }
                else
                {
                    b--;
                }
            }

            // check if a is celebrity or not

            for (int i = 0; i < n; i++)
            {
                if (i != a && (Knows(matrix, a, i) || !Knows(matrix, i, a)))
                {
                    Console.WriteLine("No celebrity found");
                    return;
                }
            }

            Console.WriteLine($"Celebrity found at index: {a}");
        }

        public static int KthSmallestElement(int[] arr, int low, int high, int kth)
        {
            while (low <= high)
            {
                if (low == kth - 1)
                {
                    return arr[low];
                }

                // find position to divide the array
                int position = Partition(arr, low, high);

                if (position - low == kth - 1)
                {
                    return arr[position];
                }

                if (position - low > kth - 1)
                {
                    KthSmallestElement(arr, low, position - 1, kth);
                }

                // traverse right array portion
                KthSmallestElement(arr, position + 1, high, kth - position);

            }

            return int.MaxValue;
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    // swap i and j 
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                    i++;
                }
            }

            // swap i and pivot
            int temp = arr[i];
            arr[i] = pivot;
            arr[high] = temp;

            return i;
        }

        public static int SquareRoot(int num)
        {
            // base case

            if (num == 0 || num == 1)
            {
                return num;
            }

            int low = 1, high = num, result = 0;

            while (low <= high)
            {
                int mid = (high + low) / 2;

                if (mid * mid == num)
                {
                    return mid;
                }

                if (mid * mid < num)
                {
                    // search right array
                    low = mid + 1;
                    // update result since we need a floor
                    result = mid;
                }
                else
                {
                    // search left array
                    high = mid - 1;
                }
            }
            return result;
        }

        public static int TrappingRainWater(int[] arr)
        {
            // {3, 0, 2, 0, 4}
            int[] maxRightArr = new int[arr.Length];
            int[] maxLeftArr = new int[arr.Length];

            int max = int.MinValue;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                max = Math.Max(max, arr[i]);
                maxRightArr[i] = max;
            }

            max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
                maxLeftArr[i] = max;
            }

            int result = 0;
            int min;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                min = Math.Min(maxRightArr[i], maxLeftArr[i]);
                result += min - arr[i];
            }

            return result;
        }

        public static int InversionCountOfArray(int[] arr, int[] temp, int low, int high)
        {
            return MergeSortInversion(arr, temp, low, high);
        }

        private static int MergeSortInversion(int[] arr, int[] temp, int low, int high)
        {
            if (low == high)
            {
                return 0;
            }
            int inversionCount = 0;
            int mid = (high + low) / 2;

            // left 
            inversionCount += MergeSortInversion(arr, temp, low, mid);

            // right 
            inversionCount += MergeSortInversion(arr, temp, mid + 1, high);

            inversionCount += MergeInversion(arr, temp, low, mid, high);


            return inversionCount;
        }

        private static int MergeInversion(int[] arr, int[] temp, int low, int mid, int high)
        {
            int inversionCount = 0;
            // merge two sorted arrays

            int k = low, i = low, j = mid + 1;

            while (i <= mid && j <= high)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                    inversionCount += (mid - i + 1); // Note
                }
            }

            // copy remaining elements
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= high)
            {
                temp[k++] = arr[j++];
            }

            // copy back to the original array to reflect sorted order
            for (i = low; i <= high; i++)
            {
                arr[i] = temp[i];
            }

            return inversionCount;
        }
    }
}
