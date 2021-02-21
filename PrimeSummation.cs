using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using TrainingSwitch.Functionalities;

namespace TrainingSwitch
{
    public class PrimeSummation
    {
        private IPrimeNumbers _primeNumbersService;

        public PrimeSummation(IPrimeNumbers primeNumbers)
        {
            _primeNumbersService = primeNumbers;
        }
        public void PrimeSeriesSummation(int n)
        {
           int finalSummation = 0;
            //;            for(BigInteger i=0;i<=n;i++)
            //            {
            //                if (_primeNumbersService.isPrime(i))
            //                    finalSummation = finalSummation + i;
            //                //else
            //                //    Console.WriteLine($"{i} : NOT PRIME");
            //            }
            int[] allPrimes = _primeNumbersService.ESieve(Convert.ToInt32(n));
            foreach (int item in allPrimes)
                finalSummation = finalSummation + item;
            Console.WriteLine($"Summation OF ALl Prime Numbers under {n} is {finalSummation}");
        }
    }
}
