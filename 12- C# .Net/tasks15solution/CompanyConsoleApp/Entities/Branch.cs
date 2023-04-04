using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyConsoleApp.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();

        public virtual ICollection<Client> Clients { get; set; } = new HashSet<Client>();


    }
}
