using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Array
{
    public class ArraySubset
    {
        // arr1 =  int[1,2,5,3,7,11]
        // arr2 = int [3,7,1]
        // no duplicate case
        public bool IsSubset(int[] arr1, int[] arr2)
        {
            if (arr1.Length == 0)
            {
                return false;
            }            

            HashSet<int> hashset = new HashSet<int>();
            foreach (var item in arr1)
            {
                hashset.Add(item);
            }

            foreach (var item in arr2)
            {
                if (!hashset.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
