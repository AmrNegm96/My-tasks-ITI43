using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class Coach
    {
        ITeamBuilder TeamBuilder;

        public void createFootballTeam(ITeamBuilder teamBuilder)
        {
            this.TeamBuilder = teamBuilder;

            teamBuilder.start();
            teamBuilder.choosePlayers();
            teamBuilder.playersTshirtNumber();
            teamBuilder.playerPosition();
            teamBuilder.stop();
        }
    }
}
