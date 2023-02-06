namespace Main
{
    internal class Program
    {
        static void Main()
        {
            Employee E1 = new Employee()
            { EmployeeID = 101, VacationStock = 10 };
            Employee E2 = new Employee()
            { EmployeeID = 102, VacationStock = 10, BirthDate = new(1900, 10, 1) };
            Employee E3 = new Employee()
            { EmployeeID = 103, VacationStock = 10 };
            Employee E4 = new Employee()
            { EmployeeID = 104, VacationStock = 10 };
            DateTime From = new DateTime(DateTime.Now.Year, 2, 2);
            DateTime To = new DateTime(DateTime.Now.Year, 2, 28);


            Department d1 = new() { DeptID = 1,DeptName="IT" };
            Club c1 = new Club() { ClubID = 1, ClubName="No name club" };

            d1.AddStaff(E1);
            d1.AddStaff(E2);
            d1.AddStaff(E3);
            d1.AddStaff(E4);

            c1.AddMember(E1);
            c1.AddMember(E2);
            c1.AddMember(E3);
            c1.AddMember(E4);

            Console.WriteLine(Department.GetList);

            Console.WriteLine("////////////////////");
            E1.RequestVacation(From,To);
            Console.WriteLine(Department.GetList);

            Console.WriteLine("////////////////////");

            BoardMember b1 = new() {EmployeeID=300,VacationStock=365 };
            SalesPerson s1= new() {AchievedTarget=10000,EmployeeID=401,VacationStock=365 };
            d1.AddStaff(s1);
            d1.AddStaff(b1);

            Console.WriteLine(Department.GetList);
            Console.WriteLine("////////////////////");

            s1.CheckTarget(100);
            Console.WriteLine( Department.GetList );
            Console.WriteLine("////////////////////");

            b1.Resign();
            Console.WriteLine(Department.GetList);
            Console.WriteLine("////////////////////");

            E2.EndOfYearOperation();
            Console.WriteLine(Club.GetListClub);
            Console.WriteLine("////////////////////");

        }
    }
}