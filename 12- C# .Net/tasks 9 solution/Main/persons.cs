using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        //notify Subscribers
        public bool CheckTarget(int Quota)
        {
            if (Quota < AchievedTarget)
            {
                //notify subscribers
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = (LayOffCause)Enum.Parse(typeof(LayOffCause), "achivedTarget") });
                return false;
            }
            else
                return true;
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            // only in achivedTarget will fires
            if (e.Cause == (LayOffCause)Enum.Parse(typeof(LayOffCause), "achivedTarget"))
            {
                base.OnEmployeeLayOff(e);
            }
            else
                return;
        }
    }
    class BoardMember : Employee
    {
        //Notify subscribers 
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = (LayOffCause)Enum.Parse(typeof(LayOffCause), "Resign") });
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == (LayOffCause)Enum.Parse(typeof(LayOffCause), "Resign"))
                base.OnEmployeeLayOff(e);
            else
                return;
        }
    }
}
