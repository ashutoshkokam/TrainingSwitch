using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class BinarySearch
    {
        private int[] _arr;
        public BinarySearch(int[] arr)
        {
            _arr = arr;
        }
        /// <summary>
        /// The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(Log n).


        /// </summary>
        /// <param name="n"></param>
        public void SearchNumber(int n)
        {
            //arr = [1,3,5,6,7,8,9,10,11,12,13,14]
            //       L           M              R

//            We basically ignore half of the elements just after one comparison.

//Compare x with the middle element.
//If x matches with middle element, we return the mid index.
//Else If x is greater than the mid element, then x can only lie in right half subarray after the mid element.So we recur for right half.
//Else(x is smaller) recur for the left half.

           int length = _arr.Length;
            int left = 0;
            int right = length - 1;
           
           int pos = GetPositionOfNumber(n,left,right);
            if (pos == -1)
                Console.WriteLine($"{n} dosent exist in array!");
            else
                Console.WriteLine($"{n} is at position {pos}!");
        }

        

        private int GetPositionOfNumber(int n,int left,int right)
        {
            int mid = 0;
            while (left <= right) {
                mid =  Convert.ToInt32( (left + right) / 2);
                if (_arr[mid] == n)
                    return mid;
                else
                {
                    if (_arr[mid] > n)
                        right = mid - 1;//// If x is smaller, ignore right half 
                    else
                        left = mid + 1;//// If x greater, ignore left half 
                }

            }
            // if we reach here, then element was 
            // not present 
            return -1;
           
        }

    }
}
