using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.PlayersFolder
{
    public class PlayerAttack : Player
    {
        public PlayerAttack()
        {
            this.Role = "Striker";
            this.Number = "9";
        }
    }
}
