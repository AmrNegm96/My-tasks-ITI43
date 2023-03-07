namespace BuilderDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeamBuilder elAhly = new TeamBuilder("El Ahly");

            Coach C_Negm = new Coach();

            C_Negm.createFootballTeam(elAhly);

            HashSet<Player> playerList = new HashSet<Player>();

            playerList = elAhly.getTeam();

            foreach (Player player in playerList)
            {
                Console.WriteLine(player.ToString());
            }
        }
    }
}