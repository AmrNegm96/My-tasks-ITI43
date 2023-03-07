using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class ELAhly : Team
    {
        public ELAhly() : base(new Attack(),"EL Ahly","Red")
        {

        }
       
        public override void Display()
        {
            Console.WriteLine($"{this.Name} , {this.ShirtColor}");
        }
    }
}
