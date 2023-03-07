using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class Player
    {
        public string Name { set; get; }
        public string Position { set; get; }
        public int TShirtNumber { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, T-Shirt Number: {TShirtNumber}";
        }
    }
}
