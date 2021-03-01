using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingSwitch
{
    public class AlienEarth
    {
        public void Calculate(int length, int[] arr, int outputLength)
        {

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < length; i++)
            {
                string str = Convert.ToString(arr[i], 2);
                //dictionary.Add(arr[i], NumberOfOnes(str));
                dictionary.Add(arr[i], str.Where(w=>w.Equals('1')).Count());
            }

            foreach (var item in dictionary.OrderByDescending(o => o.Value).Take(outputLength))
            {
                Console.Write(item.Key);
            }
            //int[] arrResult;
            //int max = 0;
            //foreach (var item in dictionary)
            //{
            //    if(item.Value>=max)
            //        arrResult.Append(item.Key)
            //}
        }
        private int NumberOfOnes(string str)
        {
            int numberOfOnes = 0;
            foreach (var item in str)
            {
                if (Convert.ToString(item) == "1")
                    numberOfOnes++;
            }
            return numberOfOnes;
        }
         ////pre-rotation of array method:
        //-----------------------------------Right rotation
        //for (int i = 0; i < n; i++)
        //{
        //    array[(i + k) % n] = int.Parse(s[i]);
        //}

        //------------------------------------Left rotation
        //for (int i = 0; i<n; i++)
        //{
        //    array[(i + (n - k)) % n] = int.Parse(s[i]);
    //}
}
}
