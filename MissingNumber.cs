using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class MissingNumber
    {
        public int[] _arr;
        public MissingNumber(int[] arr)
        {
            _arr = arr;
        }

        public int GetMissingNumber()
        {
            int missingNumber = 0;
            int n = _arr.Length;
            int totalSumValue = (n+1)*(n + 2) / 2;
            int sum = 0;
            foreach (int item in _arr)
            {
                sum = sum + item;
            }
            missingNumber = totalSumValue - sum;
            return missingNumber;
        }
    }
}
