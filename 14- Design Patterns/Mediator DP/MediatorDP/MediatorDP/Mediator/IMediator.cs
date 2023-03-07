using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP.Mediator
{
    public interface IMediator
    {
        //called by the object who want to send message (subscriber)
        void Publish(string msg);

        //method called by subscriber to add himself to mediator
        void Subscribe(ISubscriber subs);
    }
}
