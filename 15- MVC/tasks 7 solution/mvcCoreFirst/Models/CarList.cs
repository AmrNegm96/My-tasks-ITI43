namespace mvcCoreFirst.Models
{
    public class CarList
    {
        public static List<Car> cars = new List<Car>() 
        {
            new Car(){Num=1,Color="red",Model="toyota",Manufacture="2023"},
            new Car(){Num=2,Color="blue",Model="BMW",Manufacture="2023"},
            new Car(){Num=3,Color="black",Model="Mercedes",Manufacture="2023"},
            new Car(){Num=4,Color="yellow",Model="honda",Manufacture="2023"},
            new Car(){Num=5,Color="white",Model="cherry",Manufacture="2023"},
            new Car(){Num=6,Color="gray",Model="kia",Manufacture="2023"}
        };
    }
}
