using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class TeamBuilder : ITeamBuilder
    {
        private string TeamName { get; set; }
        private HashSet<Player> PlayerList { get; set; }
        private List<string> positions = new List<string>();
        public HashSet<Player> getTeam()
        {
            return PlayerList;
        }
        public TeamBuilder(string teamName)
        {
            TeamName = teamName;
            PlayerList = new HashSet<Player>();
            positions.Add("Attack");
            positions.Add("Midfield");
            positions.Add("Defence");
            positions.Add("GoalKeeper");
        }
        public void choosePlayers()
        {
            for (int i = 0; i < 11; i++)
            {
                PlayerList.Add(new Player() { Name = "Player" + (i + 1).ToString() });
            }
        }

        public void playerPosition()
        {
            int counter = 0;
            var random = new Random();
            foreach (Player player in PlayerList)
            {
                if(counter==0)
                {
                    player.Position = positions.ElementAt(3);
                    counter = 1;
                }
                else
                    player.Position = positions.ElementAt(random.Next(0,3));
            }
        }

        public void playersTshirtNumber()
        {
            var random = new Random();
            foreach (Player player in PlayerList)
            {
                player.TShirtNumber = random.Next(1, 15);
            }
        }

        public void start()
        {
            Console.WriteLine("Coach is looking for players!"); ;
        }

        public void stop()
        {
            Console.WriteLine("Coach Finished Creating a Team !");
        }
    }
}
