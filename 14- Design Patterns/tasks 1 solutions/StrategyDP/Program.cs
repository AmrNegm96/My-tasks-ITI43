namespace StrategyDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ELAhly ahly = new ELAhly();
            ElZamalek zamalek = new ElZamalek();

            ahly.Display();
            ahly.Play();

            zamalek.Display();
            zamalek.Play();

            Console.WriteLine("zamalek make counter attack");
            Console.WriteLine("///////////////////////////");

            ahly.TeamStrategy = new Defence();
            zamalek.TeamStrategy = new Attack();

            ahly.Display();
            ahly.Play();

            zamalek.Display();
            zamalek.Play();

            Console.WriteLine("///////////////////////////");

            ahly.TeamStrategy = new HighLinePressure();
            ahly.Display();
            ahly.Play();
        }
    }
}