using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using TrainingSwitch.Functionalities;

namespace TrainingSwitch
{
    public class PrimeNumbers:IPrimeNumbers
    {
        public void PrintPrimeNumbers(int n)
        {foreach (int  i in Enumerable.Range(1,100))
            {
                if (isPrime(i))
                    Console.WriteLine($"{i} : PRIME");
                else
                    Console.WriteLine($"{i} : NOT PRIME");
            }
            
        }

        public bool isPrime(int n)
        {
            bool isPrime = true;
            // Corner case
            if (n <= 1)
                return false;
            // Check from 2 to n-1
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return isPrime;
        }

        public bool isPrime(BigInteger n)
        {
            bool isPrime = true;
            // Corner case
            if (n <= 1)
                return false;
            // Check from 2 to n-1
            for (BigInteger i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return isPrime;
        }

        public int[] ESieve(int upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }
    }
}
