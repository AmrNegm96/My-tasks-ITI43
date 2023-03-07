using DecoratorDP.PlayersFolder;

namespace DecoratorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new PlayerAttack();

            Console.WriteLine($"my roles is {p1.Role} , my numbers is {p1.Number}");

            p1 = new ShadowStriker(p1);

            Console.WriteLine($"my roles is {p1.Role} , my numbers is {p1.Number}");

            Console.WriteLine("///////////////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////////////");

            Player p2 = new PlayerDefence();

            Console.WriteLine($"my roles is {p2.Role} , my numbers is {p2.Number}");

            p2 = new Libro(p2);

            Console.WriteLine($"my roles is {p2.Role} , my numbers is {p2.Number}");

            Console.WriteLine("///////////////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////////////");

            Player p3 = new PlayerMidF();

            Console.WriteLine($"my roles is {p3.Role} , my numbers is {p3.Number}");

            p3 = new PlayMaker(p3);

            Console.WriteLine($"my roles is {p3.Role} , my numbers is {p3.Number}");
        }
    }
}