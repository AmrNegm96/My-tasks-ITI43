using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompanyConsoleApp.Entities
{
    public class EmployeeClient
    {
        public int EmployeeEID { get; set; }
        public int clientCID { get; set; }
        public DateTime Visit { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
    }
}
