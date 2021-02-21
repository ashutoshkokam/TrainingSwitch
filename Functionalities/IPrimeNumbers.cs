using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TrainingSwitch.Functionalities
{
    public interface IPrimeNumbers
    {
        public bool isPrime(int n);
        public bool isPrime(BigInteger n);
        public int[] ESieve(int upperLimit);

        public void PrintPrimeNumbers(int n);
    }
}
