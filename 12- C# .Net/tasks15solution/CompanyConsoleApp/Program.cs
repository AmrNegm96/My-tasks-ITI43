using CompanyConsoleApp.Context;
using CompanyConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Original style for using statement
            
            //using (CompanyContext context = new CompanyContext())
            //{
            //}

            //new style for using statement 
            using CompanyContext context = new CompanyContext();

            // instead of PMC command {Update-Database}
            //use it carefully
            ////////////////////////////context.Database.Migrate(); 


            //context.Add(new Employee() 
            //            { FName = "amr", LName = "negm", Salary = 50000 });
            //Console.WriteLine($"number of rows affected {context.SaveChanges()}");

            var E = context.Employees.First();

            E.Email = "Amr.negm@companyMail.com";
            E.PhoneNumber= "01145889966";
            Console.WriteLine($"number of rows affected {context.SaveChanges()}");

        }
    }
}