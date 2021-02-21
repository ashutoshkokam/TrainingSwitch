using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingSwitch
{
    /// <summary>
    /// Write a short program that prints each number from 1 to 100 on a new line. 

    //For each multiple of 3, print "Fizz" instead of the number.

    //For each multiple of 5, print "Buzz" instead of the number. 


    //For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
    /// </summary>
    public class FizzBuzz
    {
        public void Print()
        {
            foreach (int i in Enumerable.Range(1, 100))
            {
                StringBuilder output = new StringBuilder(); 
                if (i % 3 == 0) output.Append("Fizz");
                if (i % 5 == 0) output.Append("Buzz");

                if (output.Length == 0)
                {
                    output.Clear();
                    output.Append(i);
                }

                Console.WriteLine(output);

            }
        }
    }
}
