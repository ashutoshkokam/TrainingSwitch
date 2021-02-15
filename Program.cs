﻿using System;
using System.Collections;
using TrainingSwitch;

namespace TrainingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World - Welcome to Training!");
            Base b1 = new Base();
            Console.WriteLine(b1.BaseProp);

            Base b = new Base("ABC");
            Console.WriteLine(b.BaseProp);
            //I am from Base class Static Constructor
            //I am from Base class Constructor
            Console.WriteLine("===============================");
            Derived d = new Derived("D_ABC");
            Console.WriteLine(d.BaseProp);
            //I am from Derived class Static Constructor
            //I am from Base class Constructor
            //I am from Derived class Constructor
            Console.WriteLine("===============================");
            Base bd = new Derived();
            //I am from Base class Constructor
            //I am from Derived class Constructor
            Console.WriteLine("===============================");
            Derived dv = b as Derived;//results is NULL
            Derived dvv = bd as Derived;//Success -Casted to Derived


            Console.WriteLine("===============================");
            //new
            b.Display(); //BAse
            d.Display(); //Derived
            bd.Display(); //Base

            Console.WriteLine("===============================");
            Console.WriteLine();
            //virtual override
            b.Print(); //Base
            d.Print(); //Derived
            bd.Print(); //Derived

            Console.WriteLine("===============================");
            //var cast = (Derived)b;//System.InvalidCastException
            var cast = (Base)d;//Success
            var cast_1 = (Derived)bd;//Success

            Console.WriteLine("===============================");
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.CalculateFiobonacci(10);

            //sring immutability
            Console.WriteLine("===============================");
            string s = "Test";

            Console.WriteLine(s);


            ModifyString(s);
            Console.WriteLine(s);//Test

            ModifyStringWithRef(ref s);
            Console.WriteLine(s);//Immutable_TEST

            int[] arr = new int[5];
            //int[] arr_1;

            ArrayList array = new ArrayList();
            Console.WriteLine(array);
            Console.WriteLine(arr.Length);
            //Console.WriteLine(arr_1.Length);

            Factorial factorial = new Factorial(7);
            factorial.Print(factorial.CalculateSeries());

            Console.WriteLine("============Extension Methods===================");
            string desc = "Take the next step in your career at ABB, working in a team that is dedicated to creating a future where innovative digital technologies allow greater access to cleaner energy.";
            string trimmedDesc = desc.TrimDesc(25);
            Console.WriteLine(trimmedDesc);
            Console.WriteLine(desc.GetWordCount());
            Console.WriteLine(trimmedDesc.GetWordCount());


            Console.WriteLine("============Pair Finder===================");


            Console.WriteLine("Hello World");
            //int[] arrNumbers = new int[] {-2,-1,1,2,3,5,6,7};
            int[] arrNumbers = new int[] { 1, 2, 3, -1, -3, 4, 5, 7, -4, 6 };
            //1,2,3,-1,-3,4,5,7,-4,6
            int finalValue = 5;
            FindPairs findPairs = new FindPairs();
            findPairs.PairFinder(arrNumbers, finalValue);
            Console.WriteLine("============Pair Finder Optimal===================");
            findPairs.PairFinderOptimal(arrNumbers, finalValue);


            string[] words = { "oath", "pea", "eat", "rain","kat" };
            char[,] board = {
                { 'o', 'a', 'a', 'n' },
                { 'e', 't', 'a', 'e' },
                { 'i', 'h', 'k', 'r' },
                { 'i', 'f', 'l', 'v'}
            };
            WordBoard wordBoard = new WordBoard();
            System.Collections.Generic.IList<string> ans = wordBoard.FindWords(board, words);
            foreach (var item in ans)
                Console.WriteLine(item);
            
        }
        public static void ModifyString( string s) 
        {
            s = "Immutable_TEST";
        }
        public static void ModifyStringWithRef(ref string s)
        {
            s = "Immutable_TEST";
        }
    }

    public class Base
    {
        const int c=0;
        readonly int r=10;
        static Base()
        {
          
            Console.WriteLine("I am from Base class Static Constructor");
        }
        public Base()
        {
            r = 20;
            Console.WriteLine("I am from Base class Constructor");
        }
        private Base(int a)
        {
          
            Console.WriteLine("I am from Base class Constructor");
        }
        public Base(string baseProp)
        {
            this.BaseProp = baseProp;
            Console.WriteLine("I am from Base class Parameterized Constructor");
        }
        public string BaseProp { get; set; }

        public void Display()
        {
            Console.WriteLine("Base:Display()");
        }

        public int Test()
        {
            int a = 0;
            try
            {
                a = 5;
                return a;
            }
            catch (Exception)
            {
                return a;
            }
            finally
            {
                //return a;//Control Can not leave the body of finally clause.
            }
        }
        public virtual void Print()
        {
            Console.WriteLine("Base:Print()");
        }
    }
    public class Derived:Base
    {
        public string DerivedProp { get; set; }
        static Derived()
        {
            Console.WriteLine("I am from Derived class Static Constructor");
        }
        public Derived(string baseProp):base(baseProp)
        {
            Console.WriteLine("I am from Derived class PAameterixed Constructor");
        }
        public Derived():base()
        {
            Console.WriteLine("I am from Derived class  Constructor");
        }
        public new void Display()
        {
            Console.WriteLine("Derived:Display()");
        }
        public override void Print()
        {
            Console.WriteLine("Derived:Print()");
        }
    }


}
