using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Refree : IObserver
    {
        public void Update(InterfaceBall Ball)
        {
           if((Ball is Football ball))
            {
                Console.WriteLine($"Refree: Looked at the Football {ball.Position}");
            }
        }
    }
}
