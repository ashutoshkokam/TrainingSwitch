using System;
using System.Collections;
using TrainingSwitch;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TrainingSwitch.Functionalities;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace TrainingSwitch
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Hello World - Welcome to Training!");


            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddTransient<IFactorial, Factorial>()
                 .AddTransient<IPrimeNumbers, PrimeNumbers>()

                .BuildServiceProvider();

            //configure console logging
            serviceProvider.GetService<ILoggerFactory>();

            var logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();
            logger.LogDebug("Starting application");


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
            //string s;
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

            Factorial factorial = new Factorial();
            factorial.Print(factorial.CalculateSeries(7));

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

            Console.WriteLine("============Board===================");

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

            Console.WriteLine("============FizzBuzz===================");
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.Print();

            Console.WriteLine("============Missing Number===================");
            int[] a = { 1, 2, 4, 5, 6 };
            MissingNumber missingNumber = new MissingNumber(a);
            Console.WriteLine($"Missing NUmber : {missingNumber.GetMissingNumber()}");

            Console.WriteLine("============Prime Number===================");
            PrimeNumbers primeNumbers = new PrimeNumbers();
            primeNumbers.PrintPrimeNumbers(100);

            Console.WriteLine("============Binary Search===================");
            int[] arrSearch = { 1, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            BinarySearch binarySearch = new BinarySearch(arrSearch);
            binarySearch.SearchNumber(7);
            binarySearch.SearchNumber(99);

            Console.WriteLine("============Linear Search===================");
            int[] arrSearchLinear = { 1, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            LinearSearch linearSearch = new LinearSearch(arrSearchLinear);
            linearSearch.SearchNumber(14);
            linearSearch.SearchNumber(99);

            Console.WriteLine("============Sorting Algo===================");
            int[] arrSort = {64, 34, 25,12, 22, 11, 90};
            SortingAlgo sortingAlgo = new SortingAlgo(arrSort);
            sortingAlgo.BubbleSort();

            Console.WriteLine("============Factorial Digit Sum===================");
            FactorialDigitSum factorialDigitSum = new FactorialDigitSum(serviceProvider.GetService<IFactorial>());
            factorialDigitSum.CalculateFactorialDigitSum(100);
            
                Console.WriteLine("============Prime Summation===================");
            PrimeSummation primeSummation = new PrimeSummation(serviceProvider.GetService<IPrimeNumbers>());
            primeSummation.PrimeSeriesSummation(2_000_000);

            Console.WriteLine("============SmallestMultiple===================");
            SmallestMultiple smallestMultiple = new SmallestMultiple();
            int n = 10;
            var res =  smallestMultiple.SmallestMultipleNumber(n);
            Console.WriteLine($"Smallest multiple of {n} is {Convert.ToInt32( res.Result)}");

            Console.WriteLine("============SmallestMultiple END===================");

            AlienEarth alienEarth = new AlienEarth();
            int[] arrEarth = { 5, 9, 8, 7, 16 };
            alienEarth.Calculate(5, arrEarth, 3);

            Console.WriteLine("============BalancedBrackets===================");

            BalancedBrackets balancedBrackets = new BalancedBrackets();
            Console.WriteLine($"BALANCED : {balancedBrackets.IsBalanced("{[()]}")}");
            Console.WriteLine($"BALANCED : {balancedBrackets.IsBalanced("{[(])}")}");
            Console.WriteLine($"BALANCED : {balancedBrackets.IsBalanced("{{[[(())]]}}")}");

            try
            {
                int j = 100;
                int i = 0;
                int k = j / i;
            }
            catch (DivideByZeroException exD)
            {
                //If i take this down it will guve me compiler error
                Console.WriteLine("DivideByZero Exception" + exD.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception"+ex.Message);
            }

            MaximumOfMinimum maximumOfMinimum = new MaximumOfMinimum();
            List<int> listNumbers = new List<int> { 2, 4, 5, 6, 8 };
            //245 2
            //456 4
            //568 5
            //5
            int maxofMin = maximumOfMinimum.GetMaximumOfMinimum(listNumbers,3);
            Console.WriteLine(maxofMin);


            C objC = new A() as C; //Base can not be casted into derived


            A objA = new C();//Derived can be casted into base

            B objB = new C();//Derived can be casted into base

            objA.Add(5,6);// Refers to A class Add Method
            objB.Add(10, 20); // Refers to B class Add Method

            //Array Clone vs Copy
            string[] arrString = { "Web", "World" };
            string[] clonedString = arrString.Clone() as string[];//returns object, needs casting, creates shallow copy

            string[] copyToStringArr = new string[2];
            arrString.CopyTo(copyToStringArr,0);//return void, copies array into destination , accpets index, creates shallow copy
            

            Console.WriteLine("END");

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

        public void Add(int a, int b)
        {
            Console.WriteLine($"Method Overloading Add(int,int): {a+b}");
        }
        public void Add(Int16 a, Int16 b)
        {
            Console.WriteLine($"Method Overloading Add(): {a + b}");
        }
        //public void Add(object a, object b)
        //{
        //    Console.WriteLine($"Method Overloading Add(): {a + b}");
        //}

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

    public class A
    {
        public int Add(int a ,int b)
        {
            return a + b;
        }
    }
    public class B:A
    {
        public  int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class C : B
    {
        public  int Add(int a, int b)
        {
            return a + b;
        }
    }


}
