using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSwitch
{
    public class SmallestMultiple
    {
        public async Task<int> SmallestMultipleNumber(int n)
        {
            return await smallestMultipleLogic(n);
        }

        public Task<int> smallestMultipleLogic(int n)
        {
            var smallestMultiple=0;
            bool flag = true;
            var num = 1;
            while (flag)
            {
                foreach (int i in Enumerable.Range(1, n))
                {
                    if (num % i != 0)
                        break;
                    if (i == n)
                    {
                        flag = false;
                        smallestMultiple = num;
                        //return smallestMultiple;
                    }

                }
                num++;
            }
            return Task.FromResult( smallestMultiple);
        }
    }
}
