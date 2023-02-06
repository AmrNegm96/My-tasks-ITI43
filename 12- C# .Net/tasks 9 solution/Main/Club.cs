using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        static List<Employee> Members = new();


        public void AddMember(Employee E)
        {
            if (!Members?.Contains(E) == true)
                Members?.Add(E);
            ///Try Register for EmployeeLayOff Event Here
            E.EmployeeLayOff += RemoveMember;
        }



        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {

            if (
                sender is Employee emp && emp != null &&
                (
                e.Cause == (LayOffCause)Enum.Parse(typeof(LayOffCause), "vacationStock")
                ||
                e.Cause == (LayOffCause)Enum.Parse(typeof(LayOffCause), "Resign")
                )
              )
            {

                if (e.Cause == (LayOffCause)Enum.Parse(typeof(LayOffCause), "vacationStock"))
                    //Console.WriteLine($"\nEmployee ID {emp.EmployeeID} deleted from Staff list due to vacationStock < 0");
                    Members?.Remove(emp);
                if (e.Cause == (LayOffCause)Enum.Parse(typeof(LayOffCause), "Resign"))
                    //Console.WriteLine($"\nEmployee ID {emp.EmployeeID} deleted from Staff list due to Resign");
                Members?.Remove(emp);
            }

            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
        public static string GetListClub
        {
            get
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < Members.Count; i++)
                    str.Append(Members[i]).Append(",");

                return str.ToString();
            }
        }
    }
}
