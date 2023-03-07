using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Player : IObserver
    {
        public void Update(InterfaceBall Ball)
        {
            if ((Ball is Football ball))
            {
                Console.WriteLine($"Player: Looked at the Football {ball.Position}");
            }
        }
    }
}
