using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public abstract class Team
    {
        public ITeamStrategy TeamStrategy { get; set; }
        public string Name { get; set; }
        public string ShirtColor { get; set; }
        public Team(ITeamStrategy Strategy, string name , string color)
        {
            TeamStrategy = Strategy;
            Name = name;
            ShirtColor = color;
        }
        public void Play()
        {
            TeamStrategy.PerformStrategy();
        }
        public abstract void Display();

    }
}
