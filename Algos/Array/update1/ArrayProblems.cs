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

    }
}
