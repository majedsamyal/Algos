using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class ProDataStructure
    {
        private List<int> lstInt;
        private Dictionary<int, int> keyValuePairs;
        public ProDataStructure()
        {
            lstInt = new List<int>();
            keyValuePairs = new Dictionary<int, int>();
        }

        public int Search(int val)
        {
            return keyValuePairs.ContainsKey(val) ? val : -1;
        }
        public void Remove(int val)
        {
            if (keyValuePairs.ContainsKey(val))
            {
                int index = keyValuePairs[val];
                keyValuePairs.Remove(val);

                int temp = lstInt[index];
                lstInt[index] = lstInt[lstInt.Count - 1];
                lstInt.RemoveAt(lstInt.Count - 1);

                keyValuePairs.Remove(lstInt[index]);
                keyValuePairs.Add(lstInt[index], index);
            }
        }
        public void Insert(int val)
        {
            if (!keyValuePairs.ContainsKey(val))
            {
                int length = lstInt.Count;
                lstInt.Insert(length, val);
                keyValuePairs.Add(val, length);
            }
        }
        public int GetRandom()
        {
            Random random = new Random();
            return random.Next(0, lstInt.Count);
        }
    }
}
