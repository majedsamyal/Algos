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
    }
}
