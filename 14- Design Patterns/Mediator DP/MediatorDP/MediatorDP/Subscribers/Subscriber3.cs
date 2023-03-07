using MediatorDP.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP.Subscribers
{

    public class Subscriber3 : ISubscriber
    {
        IMediator _mediator;

        public Subscriber3(IMediator mediator)
        {
            //subscriber 3 is not interested to recieve message
            _mediator= mediator;
            //if i want subscriber 3 also recieve a message
            //_mediator.Subscribe(this);
        }
        public void Handle(string msg)
        {
            Console.WriteLine("message received by subscriber 3 ...");
        }
        public void PublishMessage(string msg)
        {
            _mediator.Publish(msg); 
        }
    }
}
