using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Entity
{
    public class Publisher : EntityBase
    {
        string pub_id;
        string pub_name;
        string city;
        string state;
        string country;

        public string Pub_id {
            get => pub_id;
            set
            {
                if (value != pub_id)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    pub_id = value;
                }
            }
        }
        public string Pub_name {
            get => pub_name;
            set
            {
                if (value != pub_name)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    pub_name = value;
                }
            }
        }
        public string City {
            get => city;
            set
            {
                if (value != city)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    city = value;
                }
            }
        }
        public string State1 {
            get => state;
            set
            {
                if (value != state)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    state = value;
                }
            }
        }
        public string Country {
            get => country;
            set
            {
                if (value != country)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    country = value;
                }
            }
        }
    }
}
