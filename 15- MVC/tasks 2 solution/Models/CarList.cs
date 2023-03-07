using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carstask.Models
{
    public class CarList
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car(){Num=1,Color="red",Model="toyota",Manfacture="2023"},
            new Car(){Num=2,Color="blue",Model="BMW",Manfacture="2023"},
            new Car(){Num=3,Color="black",Model="Mercedes",Manfacture="2023"},
            new Car(){Num=4,Color="yellow",Model="honda",Manfacture="2023"},
            new Car(){Num=5,Color="white",Model="cherry",Manfacture="2023"},
            new Car(){Num=6,Color="gray",Model="kia",Manfacture="2023"}
        };
    }
}