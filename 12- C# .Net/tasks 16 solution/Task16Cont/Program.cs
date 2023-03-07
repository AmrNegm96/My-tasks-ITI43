namespace Task16Cont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SchoolContext context = new SchoolContext();

            //context.Add(new Teacher() { FullName = "Test1", Salary = 5000 });
            //context.Add(new Student() { FullName = "Test2", EnrollmentDate = new DateTime(2002, 1, 1) });
            //context.SaveChanges();

            //var t = context.Teachers.First();

            //t.Salary += 100;

            //when you want to select teacher type from poeple it use the filet automatically 
            //var t = context.People.OfType<Teacher>().First();

            //Console.WriteLine(context.SaveChanges());
        }
    }
}