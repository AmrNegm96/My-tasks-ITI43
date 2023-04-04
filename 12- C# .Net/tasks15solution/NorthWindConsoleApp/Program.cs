using Microsoft.EntityFrameworkCore;
using NorthWindConsoleApp.Context;
using NorthWindConsoleApp.Entities;

namespace NorthWindConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext Context = new NorthwindContext();

            //better than proxies
            #region LAZY LOADING
            //magabsh haga men el supplier aw el category madam magebtesh seeretha fel selectaya
            ////////////////////var result = (from p in Context.Products
            ////////////////////             where p.UnitsInStock==0
            ////////////////////             //select p
            ////////////////////              select p.ProductName).ToList(); 


            //awel ma enta gebt seert el category ra7 hwa 3amal join fel query
            ////////////////////var result = (from p in Context.Products
            ////////////////////              where p.UnitsInStock == 0
            ////////////////////              select new {p.ProductName, p.Category.CategoryName}).ToList(); 

            //awel ma enta gebt seert el category w el supplier ra7 hwa 3amal join benhom kolohom fel query
            //////////////////////var result = (from p in Context.Products
            //////////////////////              where p.UnitsInStock == 0
            //////////////////////              select new { p.ProductName, p.Category.CategoryName, p.Supplier.CompanyName }).ToList();

            //var result = (from p in Context.Products
            //              where p.UnitsInStock == 0
            //              select p).ToList();

            //null refernce exception because teh query didnt get category in it beacause of lazyloading
            // go to database only one time #LAZY LOADING
            //////////////foreach (var item in result)
            //////////////{
            //////////////    Console.WriteLine($"Product {item.ProductName} , Category {item.Category.CategoryName}");
            //////////////}
            ///

            /// only one trip to data base
            //var result = (from p in Context.Products
            //              .Include(p=>p.Category).Include(p=>p.Supplier) // ma3na el include eno hwa ye3mel join ma3 el category & supplier
            //              where p.UnitsInStock == 0
            //              select p).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product {item.ProductName} , Category {item.Category?.CategoryName ?? "NA"}, Supplier {item.Supplier?.CompanyName??"NA"}");
            //}
            #endregion
            //better than proxies
            #region Explicit Loading
            //var result = (from p in Context.Products
            //              where p.UnitsInStock == 0
            //              select p).ToList();


            //foreach (var item in result)
            //{
            //    if(item.Category == null)
            //    {
            //        //explicit M=>Collection 1=>Reference
            //        // N+1 trips to database
            //        //lw gabo men el DB msh hayrooh yegebo tani khalas haye3melo save fel context
            //        // lw hasal eno hwa b2a b null e3melo load ya3am
            //        Context.Entry(item).Reference(p=>p.Category).Load();
            //    }
            //    Console.WriteLine($"Product {item.ProductName} , Category {item.Category?.CategoryName ?? "NA"}");
            //}
            #endregion

            #region explicit loading automatically without any extra code install-package microsoft.entityframeworkcore.proxies
            // @ context.cs  ... UseLazyLoadingProxies();
            //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //    => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Encrypt=false")
            //.UseLazyLoadingProxies();

            //var result = (from p in Context.Products
            //              where p.UnitsInStock == 0
            //              select p).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product {item.ProductName} , Category {item.Category?.CategoryName ?? "NA"}");
            //}
            #endregion
        }
    }
}