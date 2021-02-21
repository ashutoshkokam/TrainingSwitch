using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TrainingSwitch.Functionalities;

namespace TrainingSwitch
{
    public class FactorialDigitSum
    {
        private readonly IFactorial _factorialService;
        public FactorialDigitSum(IFactorial factorialService)
        {
            _factorialService = factorialService;
        }

        public void CalculateFactorialDigitSum(BigInteger n)
        {
            BigInteger factorial = _factorialService.CalculateSeries(n);
            string strFactorial = factorial.ToString();
            BigInteger factorialSum = 0;
            foreach (char item in strFactorial)
            {
                factorialSum = factorialSum + Convert.ToInt64(item.ToString());
            }
            Console.WriteLine(factorialSum);
        }
    }
}
