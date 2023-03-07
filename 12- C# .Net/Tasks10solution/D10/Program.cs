using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static D10.ListGenerators;
using static D10.Program.LengthCompare;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ Restriction Operators

            //1.Find all products that are out of stock.

            //var results1 = ProductList.Where(p => p.UnitsInStock == 0);

            ////results = from P in ProductList
            ////          where P.UnitsInStock == 0
            ////          select P;

            //foreach (var item in results1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("//////////////////////////////////////");

            //2.Find all products that are in stock and cost more than 3.00 per unit.

            //var results2 = ProductList.Where(p => p.UnitsInStock > 0).Where(p => p.UnitPrice > 3);

            ////results2 = from p in ProductList
            ////           where p.UnitsInStock > 0 && p.UnitPrice > 3
            ////           select p;

            //foreach (var item in results2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("//////////////////////////////////////");

            //3.Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var results3 = Arr.Where((Num , i) => Num.Length < i);

            ////results3 = Arr.Where((Num) => Num.Length < Array.IndexOf(Arr, Num));

            ////results3 = from Num in Arr
            ////           where Num.Length < Array.IndexOf(Arr, Num)
            ////           select Num;

            //foreach (var item in results3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("//////////////////////////////////////");


            #endregion

            #region LINQ - Element Operators (Immediate excution)
            //1.Get first Product out of Stock

            //var result4 = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result4?.ProductName);

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;

            //Console.WriteLine(result.First());

            //Console.WriteLine("/////////////////////////");

            //2.Return the first product whose Price > 1000,unless there is no match, in which case null is returned.

            //var result5 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000 , new Product() { ProductName= "Sorry NA"});
            //Console.WriteLine(result5.ProductName);

            //var result5 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result5?.ProductName??"Sorry NA");

            //Console.WriteLine("/////////////////////////");

            //3.Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result6 = Arr.Order().Where((num, i) => num > 5).ElementAtOrDefault(1);
            //Console.WriteLine(result6);
            //var greaterThan5 = Arr.Order().SkipWhile(i => i <= 5).ElementAtOrDefault(1);
            //Console.WriteLine(greaterThan5);
            //Console.WriteLine("/////////////////////////");

            #endregion

            #region LINQ - Set Operators

            //1.Find the unique Category names from Product List

            //var DistinctCategories = ProductList.Select(p => p.Category).Distinct();

            //foreach (var category in DistinctCategories)
            //{
            //    Console.WriteLine(category);
            //}
            //Console.WriteLine("//////////////////////");

            //2.Produce a Sequence containing the unique first letter from both product and customer names.

            //var lst1 = ProductList.Select(p => p.ProductName[0]).Distinct();
            //var lst2 = CustomerList.Select(c => c.CompanyName[0]).Distinct();

            //var lst3 = ProductList.Select(p => p.ProductName[0]);
            //var lst4 = CustomerList.Select(c => c.CompanyName[0]);

            //var result = lst1.Concat(lst2);

            //result = lst3.Union(lst4);


            //foreach (var ch in result)
            //{
            //    Console.WriteLine(ch);
            //}
            //Console.WriteLine("//////////////////////");

            //3.Create one sequence that contains the common first letter from both product and customer names.

            //var lst1 = ProductList.Select(p => p.ProductName[0]);

            //var lst2 = CustomerList.Select(c => c.CompanyName[0]);


            //var result = lst1.Intersect(lst2);
            //foreach (var ch in result)
            //{
            //    Console.WriteLine(ch);
            //}
            //Console.WriteLine("//////////////////////");

            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var lst1 = ProductList.Select(p => p.ProductName[0]);

            //var lst2 = CustomerList.Select(c => c.CompanyName[0]);


            //var result = lst1.Except(lst2);
            //foreach (var ch in result)
            //{
            //    Console.WriteLine(ch);
            //}
            //Console.WriteLine("//////////////////////");

            //5.Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            //var lst1 = ProductList.Select
            //           (p => p.ProductName.Substring(p.ProductName.Length-3));

            //var lst2 = CustomerList.Select
            //           (c => c.CompanyName.Substring(c.CompanyName.Length-3));

            //var result = lst1.Concat(lst2);

            //foreach (var ch in result)
            //{
            //    Console.WriteLine(ch);
            //}
            //Console.WriteLine("//////////////////////");

            #endregion

            #region LINQ - Aggregate Operators

            //1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(i=>i%2 != 0);
            //Console.WriteLine(result);

            //2.Return a list of customers and how many orders each has.

            //var result = CustomerList.Select
            //             (c => new { CustomerName = c.CompanyName, OrderNumber = c.Orders.Count() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.Return a list of categories and how many products each has

            //var result = ProductList.GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}===={item.Count()}");
            //}

            //4.Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var results = Dictionary.Sum(s => s.Length);

            //Console.WriteLine(results);

            //6.Get the total units in stock for each product category.

            //var result = ProductList.GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}===={item.Sum(p=>p.UnitsInStock)}");
            //}

            //7.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var results = Dictionary.Min(s => s.Length);

            //Console.WriteLine(results);

            //8.Get the cheapest price among each category's products

            //var result = ProductList.GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}===={item.Min(p => p.UnitPrice)}");
            //}

            //9.Get the products with the cheapest price in each category(Use Let)

            ////////////**********************////////////////////

            //10.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var results = Dictionary.Max(s => s.Length);

            //Console.WriteLine(results);

            //11.Get the most expensive price among each category's products.

            //var result = ProductList.GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}===={item.Max(p => p.UnitPrice)}");
            //}

            //12.Get the products with the most expensive price in each category.

            //var result = ProductList.GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}===={item.Where().Max(p => p.UnitPrice)}");
            //}

            //13.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var results = Dictionary.Average(s => s.Length);
            //Console.WriteLine(results);

            //14.Get the average price of each category's products.

            //var result = ProductList.GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}===={item.Average(p => p.UnitPrice)}");
            //}


            #endregion

            #region LINQ - Ordering Operators

            //1.Sort a list of products by name

            //var result = ProductList.OrderByDescending(p => p.ProductName);

            //foreach(var item in result) 
            //{ 
            //    Console.WriteLine(item.ProductName);
            //}

            //2.Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x, new CaseInsensitiveComparer());

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //3.Sort a list of products by units in stock from highest to lowest.

            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName}===={item.UnitsInStock}");
            //}
            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result1 = Arr.OrderByDescending(s => s , new LengthCompare());

            //foreach ( string s in result1 ) 
            //{
            //    Console.WriteLine(s);
            //}

            //var result2 = Arr.Order();

            //foreach (string s in result2)
            //{
            //    Console.WriteLine(s);
            //}



            //5.Sort first by word length and then by a case-insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = words.OrderBy(s => s, new LengthCompare()).ThenBy(x => x, new CaseInsensitiveComparer());

            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}



            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result1 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var s in result1)
            //{
            //    Console.WriteLine($"{s.Category}==={s.UnitPrice}");
            //}



            //7.Sort first by word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderByDescending(s => s, new LengthCompare())
            //             .ThenByDescending(x => x, new CaseInsensitiveComparer());


            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}


            //8.Create a list of all digits in the array
            //whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(a => a[1]=='i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ - Partitioning Operators
            //1.Get the first 3 orders from customers in Washington

            //var result = CustomerList.Where(p=>p.Country== "Germany").Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2.Get all but the first 2 orders from customers in Washington.

            //var result = CustomerList.Where(p => p.Country == "Germany").Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.Return elements starting from the beginning of the array
            //until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((i,j)=> i>j);
            //foreach ( var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(x => x % 3 != 0);
            //foreach(var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //5.Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((i, j) => i > j);
            //foreach(var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region LINQ - Projection Operators

            //1.Return a sequence of just the names of a list of products.

            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2.Produce a sequence of the uppercase and lowercase versions of each word in
            //the original array(Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var tempresult = new object[words.Length];
            //for (var i = 0; i < words.Length; i++)
            //{
            //    tempresult[i] = new { upper = words[i].ToUpperInvariant(), lower = words[i].ToLowerInvariant() };
            //}
            //foreach (var word in tempresult)
            //{
            //    Console.WriteLine(word);
            //}

            //3.Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductList.Select(p => new {Price= p.UnitPrice , Name=p.ProductName}) ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Price);
            //}

            //4.Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((i, j) => i == j);
            //int x = 0;
            //foreach ( var i in result )
            //{
            //    Console.WriteLine($"{Arr[x++]} : {i}");
            //}

            //5.Returns all pairs of numbers from both arrays such that
            //the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //Result
            //Pairs where a<b:
            //0 is less than 1
            //0 is less than 3
            //0 is less than 5
            //0 is less than 7
            //0 is less than 8
            //2 is less than 3
            //2 is less than 5
            //2 is less than 7
            //2 is less than 8
            //4 is less than 5
            //4 is less than 7
            //4 is less than 8
            //5 is less than 7
            //5 is less than 8
            //6 is less than 7
            //6 is less than 8

            //6.Select all orders where the order total is less than 500.00.

            //var result = CustomerList.Select(c => c.Orders);
            //for(int i=0; i<result.Count(); i++)
            //{
            //    for(int j =0; j < result.ElementAt(i).Length; j++)
            //    {
            //        if(result.ElementAt(i)[j].Total<500.00m)
            //            Console.WriteLine(result.ElementAt(i)[j]);
            //    }
            //}

            //7.Select all orders where the order was made in 1998 or later.

            //var result = CustomerList.Select(c => c.Orders);
            //for (int i = 0; i < result.Count(); i++)
            //{
            //    for (int j = 0; j < result.ElementAt(i).Length; j++)
            //    {

            //        if (DateTime.Compare(result.ElementAt(i)[j].OrderDate, new DateTime(1998, 1, 1)) >= 0)
            //        {
            //            Console.WriteLine(result.ElementAt(i)[j].OrderDate);
            //        }
            //    }
            //}

            #endregion

            #region LINQ - Quantifiers

            //1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First)
            //contain the substring 'ei'.

            //var result = Dictionary.Any(word => word.Contains("ei"));
            //Console.WriteLine(result);

            //2.Return a grouped a list of products only for categories
            //that have at least one product that is out of stock.

            //var result = ProductList.Where(p => p.UnitsInStock==0).GroupBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} == {item.Count()}");
            //    for(int i=0; i<item.Count(); i++)
            //    {
            //        Console.WriteLine(item.ElementAt(i).ProductName);
            //    }
            //}

            //3.Return a grouped a list of products only for categories
            //that have all of their products in stock.

            //var result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} == {item.Count()}");
            //    for (int i = 0; i < item.Count(); i++)
            //    {
            //        Console.WriteLine(item.ElementAt(i).ProductName);
            //    }
            //}

            #endregion

            #region LINQ - Grouping Operators

            //1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> Lst = new() { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14 };
            //int[] result;
            //int[] arr;
            //for (int i = 0; i<5;i++)
            //{
            //    result = new int[Lst.Count()];
            //    arr = Lst.Where(x => x % 5 == i).ToArray();

            //    Console.WriteLine($"Numbers with a remainder of {i} when divided by 5:");
            //    foreach (int x in arr)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}


            //2.Uses group by to partition a list of words by their first letter.

            //var result = Dictionary.GroupBy(p => p.ElementAt(0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //3.Consider this Array as an Input

            string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            var result = Arr.GroupBy(word => word, new wordComparer());

            foreach (var item in result)
            {
                Console.WriteLine("///////////////");
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.Trim());
                }
            }
            #endregion
        }
        public class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string L, string R)
            {
                return string.Compare(L, R, StringComparison.OrdinalIgnoreCase);
            }
        }
        public class LengthCompare : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                return x.Length.CompareTo(y.Length);
            }
            
        }
        public class wordComparer : IEqualityComparer<string>
        {
            public bool Equals(string? L, string? R)
            {
                var temp1 = L.Trim().ToCharArray();
                var temp2 = R.Trim().ToCharArray();
                Array.Sort(temp1);
                Array.Sort(temp2);
                string st1 = new string(temp1);
                string st2 = new string(temp2);
                return st1.Equals(st2);
            }

            int IEqualityComparer<string>.GetHashCode(string obj)
            {
                return 0;
            }
        }
    }
}