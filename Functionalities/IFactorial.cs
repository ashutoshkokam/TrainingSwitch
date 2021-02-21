using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TrainingSwitch.Functionalities
{
    public interface IFactorial
    {
        public BigInteger CalculateSeries(BigInteger n);
        public void Print(object o);
    }
}
