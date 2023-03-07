using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Football : InterfaceBall
    {
        private Position position;
        public Football(Position _position)
        {
            position= _position;
        }
        public Position Position
        {
            get { return position; }
            set 
            { 
                if (value.x != Position.x || value.y != Position.y || value.z != Position.z)
                {
                    position = value;
                    Notify();
                }
                 
            }
        }
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer.");
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
