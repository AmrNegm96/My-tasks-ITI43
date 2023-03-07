using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.PlayersFolder
{
    public class Player
    {
        public virtual string Role { get; protected set; }
        public virtual string Number { get; protected set; }
    }
}
