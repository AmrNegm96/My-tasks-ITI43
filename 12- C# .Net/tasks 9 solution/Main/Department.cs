using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        static List<Employee> Staff = new();

        public static string GetList
        {
            get
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < Staff.Count; i++)
                    str.Append(Staff[i]).Append(" , ");

                return str.ToString();
            }
        }

        public void AddStaff(Employee E)
        {
            if (!Staff?.Contains(E) == true)
                Staff?.Add(E);

            E.EmployeeLayOff += RemoveStaff;

        }

        ////CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (
                sender is Employee emp && emp != null &&
                (
                e.Cause == LayOffCause.vacationStock
                ||
                e.Cause == LayOffCause.age
                ||
                e.Cause == LayOffCause.achivedTarget
                ||
                e.Cause == LayOffCause.Resign
                )
              )
            {
                if (e.Cause == LayOffCause.vacationStock)
                    Console.WriteLine($"Employee ID {emp.EmployeeID} deleted from departement list due to vacationStock < 0");

                if (e.Cause == LayOffCause.age)
                    Console.WriteLine($"Employee ID {emp.EmployeeID} deleted from departement list due to age>60");

                if (e.Cause == LayOffCause.achivedTarget)
                    Console.WriteLine($"Employee ID {emp.EmployeeID} deleted from departement list due to achivedTarget");

                if (e.Cause == LayOffCause.Resign)
                    Console.WriteLine($"Employee ID {emp.EmployeeID} deleted from departement list due to Resign");

                Staff?.Remove(emp);
            }

        }



    }
}
