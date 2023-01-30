using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book() { }
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
        decimal _Price)
        {
            ISBN= _ISBN;
            Title= _Title;
            Authors= _Authors;  
            PublicationDate= _PublicationDate;
            Price= _Price;
        }
        public override string ToString()
        {
            return $"""
                    The book title: {this.Title}
                    , its ISBN: {this.ISBN} 
                     and its price is: {this.Price} EGP
                    """;
        }
    }
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            StringBuilder SB = new StringBuilder();

            foreach(string item in B.Authors)
            {
                SB.Append(item);
                SB.Append(",");

            }
            SB.Remove(SB.Length-1,1);
            return SB.ToString();
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
    public class LibraryEngine
    {
        public delegate string BookDelDT (Book B);

        public static void ProcessBooks(List<Book> bList , BookDelDT fPtr )
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr?.Invoke(B)?? "-1");
            }
        }
        public static void ProcessBooksV2(List<Book> bList, Func <Book , string> fPtr )
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr?.Invoke(B) ?? "-1");
            }
        }
    }
}
