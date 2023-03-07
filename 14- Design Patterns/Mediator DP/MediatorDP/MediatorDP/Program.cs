using MediatorDP.Mediator;
using MediatorDP.Subscribers;

namespace MediatorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We want Subs1 contact Subs2 but via Controller called mediator
            //code against abstraction
            IMediator mediator = new ConcreteMediator();

            Subscriber1 subs1 = new Subscriber1(mediator);

            Subscriber2 subs2 = new Subscriber2(mediator);

            Subscriber3 subs3 = new Subscriber3(mediator);

            subs3.PublishMessage("message from subscriber 3 ");

        }
    }
}