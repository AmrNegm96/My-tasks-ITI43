using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    public class Subscribers
    {
        public void OnPublishing(object source , EventArgs e)
        {
            Console.WriteLine("Subscriber reading publish now");
        }
    }
}
