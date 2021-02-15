using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class FindPairs
    {
        public void PairFinder(int[] arr, int value)
        {
			
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					int sum = arr[i] + arr[j];
					if (sum == value)
						Console.WriteLine("Pair: " + arr[i].ToString() + " " + arr[j].ToString());


				}
			}

		}
		public void PairFinderOptimal(int[] arr, int value)
		{
			Array.Sort(arr);
			int i = 0;
			int j = arr.Length - 1;

			while (i < j) {
				int sum = arr[i] + arr[j];
				if (sum == value)
					Console.WriteLine("Pair: " + arr[i].ToString() + " " + arr[j].ToString());
				if (sum < value)
						i++;
				else
						j--;
				
			}

		}
	}
}
