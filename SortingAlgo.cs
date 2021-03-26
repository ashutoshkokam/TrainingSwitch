using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class SortingAlgo
    {
        private int[] _arr;
        public SortingAlgo(int[] arr)
        {
            _arr = arr;
        }
        public void BubbleSort()
        {
            PerformRecursiveBubbleSort(_arr.Length);
            PrintArrayElements();
        }

        public void PerformRecursiveBubbleSort(int n)
        {
            // int []arr = {64, 34, 25, 12, 22, 11, 90}; 
            // Base case
            int length = n;
            if (length == 1)
                return;
          
            for (int i = 0; i < length-1; i++) 
            {
                if (_arr[i] > _arr[i + 1])
                {
                    int temp = _arr[i];
                    _arr[i] = _arr[i + 1];
                    _arr[i + 1] = temp;
                }
            }
            PerformRecursiveBubbleSort(length-1);
        }

       

        private void PrintArrayElements()
        {
            foreach (int item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
