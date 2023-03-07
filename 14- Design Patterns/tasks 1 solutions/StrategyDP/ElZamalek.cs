using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class ElZamalek : Team
    {
        public ElZamalek() : base(new Defence(),"El Zamalek","White")
        {

        }
        public override void Display()
        {
            Console.WriteLine($"{this.Name} , {this.ShirtColor}");
        }
    }
}
