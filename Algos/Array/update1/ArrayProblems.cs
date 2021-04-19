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

        public static void RightRotateArray(int[] arr, int count)
        {
            // [1,2,3,4,5,6,7]          
            // rotate by right 1 = [7,1,2,3,4,5,6]
        }

    }
}
