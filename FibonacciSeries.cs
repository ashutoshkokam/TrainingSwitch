using System;
using System.Collections.Generic;
using System.Text;
using TrainingSwitch.Functionalities;

namespace TrainingSwitch
{
    public class FibonacciSeries
    {
        public void CalculateFiobonacci(int count) 
        {
            int n1 = 0,n2=1,n3;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 2; i < count; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
             
            }
        }
    }
}
