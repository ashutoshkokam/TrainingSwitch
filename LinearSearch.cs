using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class LinearSearch
    {
        private int[] _arr;
        public LinearSearch(int[] arr)
        {
            _arr = arr;
        }
        public void SearchNumber(int n)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == n)
                {
                    Console.WriteLine($"{n} is at position {i}!");
                    return;
                }
            }
            Console.WriteLine($"{n} dosent exist in array!");
        }

    }
}
