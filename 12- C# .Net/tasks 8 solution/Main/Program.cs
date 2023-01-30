namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Book B1 = new Book("1236666", "A", new string[] { "a", "b", "c" }, dateTime, 200);
            Book B2 = new Book("345", "B", new string[] { "a", "b", "c" }, dateTime, 300);
            Book B3 = new Book("567", "C", new string[] { "a", "b", "c" }, dateTime, 500);
            Book B4 = new Book("891", "D", new string[] { "a", "b", "c" }, dateTime, 300);
            Book B5 = new Book("568", "E", new string[] { "a", "b", "c" }, dateTime, 100);

            List<Book> list = new List<Book>();
            list.Add(B1);
            list.Add(B2);
            list.Add(B3);
            list.Add(B4);
            list.Add(B5);

            Console.WriteLine("////////////////////");
            LibraryEngine.ProcessBooks(list, BookFunctions.GetTitle);
            Console.WriteLine("////////////////////");
            LibraryEngine.ProcessBooks(list, BookFunctions.GetAuthors);
            Console.WriteLine("////////////////////");
            LibraryEngine.ProcessBooks(list, BookFunctions.GetPrice);
            Console.WriteLine("////////////////////");

            Console.WriteLine("////////////////////");
            LibraryEngine.ProcessBooksV2(list, BookFunctions.GetTitle);
            Console.WriteLine("////////////////////");
            LibraryEngine.ProcessBooksV2(list, BookFunctions.GetAuthors);
            Console.WriteLine("////////////////////");
            LibraryEngine.ProcessBooksV2(list, BookFunctions.GetPrice);
            Console.WriteLine("////////////////////");


            Func<Book , string> fPtr2 = delegate (Book b) { return b.ISBN; };
            Console.WriteLine(fPtr2(B1));
            Console.WriteLine("////////////////////");

            Func<Book, DateTime> fPtr3 =  b => b.PublicationDate;
            Console.WriteLine(fPtr3(B1));


        }
    }
}