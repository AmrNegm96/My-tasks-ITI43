namespace DelegatesandEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher PUB = new Publisher();
            Subscribers Sub1= new Subscribers();
            Subscribers Sub2= new Subscribers();

            PUB.PublisherEvent += Sub1.OnPublishing;
            PUB.PublisherEvent += Sub2.OnPublishing;

            PUB.Publish();
        }
    }
}