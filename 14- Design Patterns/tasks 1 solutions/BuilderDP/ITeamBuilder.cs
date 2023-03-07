using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public interface ITeamBuilder
    {
        void start();
        void choosePlayers();
        void playersTshirtNumber();
        void playerPosition();
        void stop();

        HashSet<Player> getTeam(); //quicker because it contain unique items

    }
}
