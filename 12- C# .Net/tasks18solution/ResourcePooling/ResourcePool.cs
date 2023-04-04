using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePooling
{
    public class ResourcePool
    {
        internal Queue<Resource> pool = new Queue<Resource>();

        public int poolSize { get => pool.Count; }

        public Resource getResource()
        {
            if(pool.Count > 0)
                return pool.Dequeue();
            return new Resource(this) { Name = $"R{pool.Count + 1}" };
        }
        internal void AddToPool(Resource R)
        {
            pool.Enqueue(R);
        }
    }
}
