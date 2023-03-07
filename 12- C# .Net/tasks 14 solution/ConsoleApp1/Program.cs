using ConsoleApp1.Context;
using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Put all code inside try and generate finally call inside it dispose connection 
            using (LibraryContext context= new LibraryContext())// from it i can contact database)
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();  // make sure that database created if not create it 

                #region Insert
                //create object
                //Title title1 = new Title() { AuthorName="abc",PromotionalPrice=13.5M };
                //Title title2 = new Title() { AuthorName="xyz",PromotionalPrice=10.5M };

                //track state //detached
                //Console.WriteLine($"{context.Entry(title2).State}");

                // add object to Dbset // local repository (titles)
                //context.Titles.Add(title1); 
                //context.Titles.Add(title2);


                //track state //added
                //Console.WriteLine($"{context.Entry(title2).State}");

                //commit changes to DB (transactional by default all done or all not done)
                //context.SaveChanges();  //like update of adaptor


                //track state //unchanged
                //Console.WriteLine($"{context.Entry(title2).State}"); 

                //Console.WriteLine(title1.Id);

                context.Add(new Branch() { City = "cairo", OpenHour = 10, ZipCode = "12111" });
                Console.WriteLine(context.SaveChanges());

                #endregion

                #region Select
                //var Result = context.Titles.FirstOrDefault();
                //Console.WriteLine(Result?.AuthorName ?? "NA");
                #endregion

                #region Update
                //var result = (from T in context.Titles
                //             where T.Forward == null
                //             select T).First();
                //result.PromotionalPrice = 0.75M * result.PromotionalPrice;

                //context.SaveChanges();

                #endregion

                #region Delete
                //var t = context.Titles.FirstOrDefault(t => t.AuthorName == "abc");
                //if(t != null)
                //{
                //    context.Titles.Remove(t);
                //}
                //context.SaveChanges();
                #endregion


            }

        }
    }
}