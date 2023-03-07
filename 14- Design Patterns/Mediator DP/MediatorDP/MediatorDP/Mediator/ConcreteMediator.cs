using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP.Mediator
{
    public class ConcreteMediator : IMediator
    {
        List<ISubscriber> subscribers = new List<ISubscriber>();
        public void Publish(string msg)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Handle(msg);
            }
        }

        public void Subscribe(ISubscriber subs)
        {
            subscribers.Add(subs);
        }
    }
}
