using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        //notify subscribers function
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            //Event fires here....
            EmployeeLayOff?.Invoke(this, e);
        }



        public int EmployeeID
        {
            get; set;
        }

        public DateTime BirthDate
        {
            get;
            set;
        }


        public int VacationStock
        {
            get;
            set;
        }


        public bool RequestVacation(DateTime From, DateTime To)
        {
            int days = To.Day - From.Day;
            VacationStock -= days;


            if (VacationStock >= 0)
            {
                Console.WriteLine($"Valid Request of vacation employee with ID: {EmployeeID}");
                return true;
            }
            else
            {
                //notify subscribers
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = (LayOffCause)Enum.Parse(typeof(LayOffCause), "vacationStock") });
                return false;
            }
        }


        public void EndOfYearOperation()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (age <= 60)
                Console.WriteLine($"Employee {EmployeeID} has age <=60");

            else
            {
                //notify subscribers
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = (LayOffCause)Enum.Parse(typeof(LayOffCause), "age") });
            }
        }

        public override string ToString()
        {
            return $"Employee ID = {EmployeeID}  " +
                $"vacationBalance= {VacationStock}";
        }
    }


    public enum LayOffCause
    {
        vacationStock, age, achivedTarget, Resign
    }



    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause
        {
            get; set;
        }
    }
}
