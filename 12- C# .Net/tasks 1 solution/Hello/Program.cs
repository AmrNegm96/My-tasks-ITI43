using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace helloWorld
{
    class helloWorldApp
    {
        public static int LongestSpace(int[] Arr)
        {
            int longestSpace = 0;
            int temp;   

            for( int i = 0; i < Arr.Length; i++ )
            {
                for(int j=1; j< Arr.Length-i ; j++)
                {
                    if (Arr[i] == Arr[j])
                    {
                        temp = j - i -1 ;

                        if( temp > longestSpace )
                        {
                            longestSpace = temp;
                        }
                    }
                }
            }
            return longestSpace;
        }

        public static string ReverseWords (string str)
        {
            string [] arr = str.Split(" ");
            Array.Reverse(arr);
            str  = string.Join(" ", arr);
            return str; 
        }

        public static string ReverseWordsV2(string str)
        {
            string[] arr = str.Split(" ");

            int start = 0;
            int end = arr.Length-1;

            while( end > start)
            {
                string temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;
                start++;
                end--;

            }

            str = string.Join(" ", arr);

            return str;
        }



        // we shall remove the topmost number 1000000
        // and add 000000

        //000000
        // to

        //……………

        //999999

        //Total number of digits = 1000000×6=6000000

        //All 10
        // digits 0
        // to 9
        // have equal representation.

        //Hence number of 1s=600000010=600000

        //Reinstating 1000000
        // , we have one more1
        //

        //Total number of  1s= 600001
        /// nx10^(n-1)+1
        // int[] arr = Enumerable.Range(1, (int)Math.Pow(10, 8)).ToArray();


        public static void countDigitOne(int n)
        {

            //int num = 11122111;
            //string[] str = num.ToString().Split("1");
            //Console.WriteLine(str.Length - 1);
            //Console.WriteLine("s {0} , {1} , {2} , {3} , {4} , {5} , {6} e", str[0], str[1], str[2], str[3], str[4], str[5], str[6]);

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();


            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                string str = i.ToString();
                counter = counter + str.Split("1").Length - 1;
            }

            stopwatch.Stop();

            Console.WriteLine("the number is {0}" , counter);
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            
        }


        public static void countDigitOneV3(int n)
        {


            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            int counter = 0;
            int y = 0;


            for (int i = 1; i <= n; i++)
            {
                y = i;

                string str = y.ToString();

                if(str.Contains("1"))
                {
                    while (y != 0)
                    {
                        int x = y % 10;
                        if (x == 1) counter++;
                        y = y / 10;
                    }
                } 
            }

            stopwatch.Stop();

            Console.WriteLine("the number is {0}" , counter);
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

        }

        public static void countDigitOneV2(int n)
        {


            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();


            double ones = n * Math.Pow(10, (n - 1)) + 1;


            stopwatch.Stop();

            Console.WriteLine("the number is {0}", ones);
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

        }

        // static function to be called by class not by object
        static void Main()
        {
            #region day1 tasks 
            System.Console.WriteLine("Hello World");


            Console.WriteLine("////////////////////////////////////////////////");
            #endregion

            #region day 2 tasks

            #region task A
            int[] Arr1 = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            int[] Arr2 = { 1, 1, 1, 1, 1, 1, 1, 1 };

            Console.WriteLine(LongestSpace(Arr1));
            Console.WriteLine(LongestSpace(Arr2));


            Console.WriteLine("////////////////////////////////////////////////");
            #endregion



            #region task B 2 versions
            Console.WriteLine(ReverseWords("this is a test"));
            Console.WriteLine(ReverseWords("all your base"));
            Console.WriteLine(ReverseWords("world"));

            Console.WriteLine("////////////////////////////////////////////////");

            Console.WriteLine(ReverseWordsV2("this is a test"));
            Console.WriteLine(ReverseWordsV2("all your base"));
            Console.WriteLine(ReverseWordsV2("world"));

            Console.WriteLine("////////////////////////////////////////////////");
            #endregion

            #region Task C

            #region V1(10-11sec)
            countDigitOne((int)Math.Pow(10, 8));
            Console.WriteLine("////////////////////////////////////////////////");
            #endregion

            #region V2
            countDigitOneV2(8);
            Console.WriteLine("////////////////////////////////////////////////");
            #endregion

            #region V3
            countDigitOneV3((int)Math.Pow(10, 8));
            Console.WriteLine("////////////////////////////////////////////////");
            #endregion
            #endregion


            #endregion
        }
    }
}