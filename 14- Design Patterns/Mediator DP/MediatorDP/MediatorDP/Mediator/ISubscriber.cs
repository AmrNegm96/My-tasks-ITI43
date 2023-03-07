using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP.Mediator
{
    public interface ISubscriber
    {
        //this method will be called by mediator
        void Handle(string msg);
    }
}
