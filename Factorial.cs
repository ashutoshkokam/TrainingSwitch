using System;
using System.Collections.Generic;
using System.Text;
using TrainingSwitch.Functionalities;

namespace TrainingSwitch
{
    public class Factorial: IFunctionalities
    {
        private int _number = 0;
        public Factorial(int n)
        {
            _number = n;
        }
        public int CalculateSeries()
        {
            int fact = 1;
            for (int i = 1; i <= _number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public void Print(object o)
        {
            Console.WriteLine("=============================");
            Console.WriteLine($"Factorial of {_number} is :{o.ToString()}");
        }
    }
}
