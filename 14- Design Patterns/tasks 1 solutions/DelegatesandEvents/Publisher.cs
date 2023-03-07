using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    public class Publisher
    {
        public delegate void PublisherEventHandler(object sender, EventArgs e);

        public event PublisherEventHandler PublisherEvent;
        public void Publish()
        {
            Console.WriteLine("Publishing things");
            OnPublishing();
        }   
        protected virtual void OnPublishing()
        {
            if(PublisherEvent != null)
            {
                PublisherEvent(this, EventArgs.Empty);
            }
        }
    }
}
