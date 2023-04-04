using day16task.Context;
using Microsoft.EntityFrameworkCore;

namespace day16task
{
    internal class Program
    {
        //try to optimize relation between trips to database
        //and quantity of data you get it to ram

        //we have a way to make reverse engineering without using powerTool
        static void Main(string[] args)
        {
            //using new style
            using NorthwindContext context = new NorthwindContext();

            #region differnce between local copy and DB and find approach

            //skipWhile  => does not work in DB Can work in local
            //skip => work 
            //var result = context.Products.Take(10).ToList();

            ////trip to DB is done
            //Console.WriteLine($"Count of data in database {context.Products.Count()}");

            ////No trip to DB
            //Console.WriteLine($"Count of data in local copy in local {context.Products.Local.Count()}");




            // Approach of searching in the local copy first 
            //then search in DB
            //if (context.Products.Local.Any(p => p.UnitsInStock == 0))
            //{
            //    Console.WriteLine("out of unit of stocks");
            //}
            //else if (context.Products.Any(p => p.UnitsInStock == 0))
            //{
            //    Console.WriteLine("out of unit of stocks");
            //}
            //else
            //{
            //    Console.WriteLine("All products are in stock stocks");
            //}

            //Same as Find() but find use PK (even if composite key) ID in this way 
            // if product with id = 2 in local no trip to db
            //var prd = context.products.find(2);
            // if product with id = 15 not found in local go to a trip to db
            //prd = context.Products.Find(15);

            //Console.WriteLine(prd?.ProductName??"NA");

            #endregion

            #region Read only no tracking
            //var result = context.Products.Take(10).AsNoTracking().ToList(); 
            //no change in database because it is read only data
            //result[0].ProductName = "Test";

            //Console.WriteLine($"Number of rows affected {context.SaveChanges()}");
            #endregion

            #region Delete , soft delete (global query filter)
            // inside the entity of product make the global query filter
            // if i have more than query filter it will take only last one

            //the discontinuaty filter will be added in the qquery in DB
            ////Console.WriteLine(context.Products.First().ProductName);
            ////Console.WriteLine(context.Products.IgnoreQueryFilters().First().ProductName);
            #endregion

            #region For sql satetment that return product I want to run sql statement directly from here 

            //fromsqlraw => sql statement w/o any parameters
            //fromSql and sql interpolated => against sql injection w/ parameters  

            //products returned are tracked 
            //var prds  = context.Products
            //    .FromSqlRaw("select * from Products where UnitsInStock=0").ToList();
            //prds[0].ProductName += "**"; // it will be updated in DB

            //linQ on top of sqlRaw will run in sql server not in client memory
            ////var prds = context.Products
            ////    .FromSqlRaw("select * from Products where UnitsInStock=0")
            ////    .OrderByDescending(p=>p.UnitsInStock)
            ////    .FirstOrDefault();

            ////prds.ProductName += "**"; // it will be updated in DB


            //Can not make linq with store procedures 
            // So you have to make it toList() then make linq statements in Ram
            // Also the objects still tracked in this approach
            //////var prds = context.Products
            //////    .FromSqlRaw("Exec SelectAllProducts").ToList() // get all data from DB
            //////    .OrderByDescending(p => p.UnitsInStock) //make this linq in memory 
            //////    .FirstOrDefault();

            //////prds.ProductName += "**"; // it will be updated in DB


            //Safe against sql injection (statement or proc)
            //Also objects are tracked
            ////int prdUnits = 20;
            ////var prds = context.Products
            ////    .FromSql($"select Top(1) from Products where UnitsInStock>{prdUnits}").FirstOrDefault();
            ////prds.ProductName += "**"; // it will be updated in DB


            //context.SaveChanges();

            #endregion



            #region for sql statement that does not return Objects

            ////int prdID = 6;
            ////string newName = "updated";
            ////int r = context.Database.ExecuteSql($"Exec UpdateProductNameByProductID {prdID},{newName}");
            ////Console.WriteLine(r);



            //sqlquery can send parameter => return sacalar value
            // sql query raw cant send parameter
            //int prdUints = 0;
            //var prdPrice = context.Database.SqlQuery<decimal>($"Select Max(UnitPrice) As Value from Products where UnitsInStock={prdUints}").First();
            //Console.WriteLine(prdPrice);



            /// entity that will return with no key 

            //////var results = context.Set<TenMostExpensiveProductsResult>().FromSqlRaw("Exec [Ten Most Expensive Products]").ToList();

            //////foreach ( var result in results )
            //////{
            //////    Console.WriteLine($"{result.TenMostExpensiveProducts}===>{result.UnitPrice}");
            //////}

            #endregion


            #region EF Power tools proc and views (use that will not return entity)

            // power tools convert proc to functions 

            //var SPs = new NorthwindContextProcedures(context);

            //int r = (await SPs.UpdateProductNameByProductIDAsync(1, "kkkk"));
            //Console.WriteLine(r);

            //var SPresults = await SPs.CustOrderHistAsync("ANTAR");

            //foreach (var SP in SPresults)
            //{
            //    Console.WriteLine(SP.ProductName);
            //}
            #endregion


            #region Partial function in partial class
            //NorthwindContext.Developer.cs => Name of partial class
            #endregion





        }
    }
}