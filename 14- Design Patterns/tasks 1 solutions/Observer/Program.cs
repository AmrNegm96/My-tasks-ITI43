using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Football ball = new Football(new Position() { x = 10, y = 10, z = 10 });

            Player player1 = new Player();
            Player player2 = new Player();
            Refree refree = new Refree();

            ball.Attach(player1);
            ball.Attach(player2);
            ball.Attach(refree);

            //Console.WriteLine(ball.Position.x.GetHashCode());
            //ball.Position.x = 100;
            //Console.WriteLine(ball.Position.x.GetHashCode());


            ball.Position = new Position() { x = 0, y = 0, z = 0 };
            ball.Position = new Position() { x = 100, y = 100, z = 100 };

        }
    }
}