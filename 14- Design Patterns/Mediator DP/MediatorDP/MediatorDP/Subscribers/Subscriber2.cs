using MediatorDP.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP.Subscribers
{

    public class Subscriber2 : ISubscriber
    {
        public Subscriber2(IMediator mediator)
        {
            mediator.Subscribe(this);
        }
        public void Handle(string msg)
        {
            Console.WriteLine("message received by subscriber 2 ..."+msg);
        }
    }
}
