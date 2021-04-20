using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class MaximumOfMinimum
    {
        public int  GetMaximumOfMinimum(List<int> arr,int k)
        {
            //k=3
            //n=5
            // 2, 4, 5, 6, 8 
            //245 2
            //456 4
            //568 5
            
            int maxOfMin = 0;
            int n = arr.Count;
            int min;
            //loopthrough (5-3)+1 up to index 2
            for (int i = 0; i < (n - k)+1; i++)
            {
                min = arr[i];
                //loop j tthrough 0+3,1+3,2+3
                for (int j = i+1; j <i+k; j++)
                    min = arr[j] < min ? arr[j] : min;

                if (min > maxOfMin)
                    maxOfMin = min;
            }

            return maxOfMin;
        }
    }
}
