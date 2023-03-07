using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public interface ITeamStrategy
    {
        void PerformStrategy();
    }
    public class Attack : ITeamStrategy
    {
        public void PerformStrategy()
        {
            Console.WriteLine("Attack Attack Attaaaack!!!!");
        }
    }
    public class Defence : ITeamStrategy
    {
        public void PerformStrategy()
        {
            Console.WriteLine("go back go back defence");
        }
    }

    public class HighLinePressure : ITeamStrategy
    {
        public void PerformStrategy()
        {
            Console.WriteLine("HighLine Pressure");
        }
    }
}
