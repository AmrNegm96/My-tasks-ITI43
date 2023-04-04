using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePooling
{
    public class Resource
    {
        public required string Name { get; set; }

        ResourcePool resourcePool;

        public void UseResource() => Console.WriteLine($"Using Resource {Name} ....");

        internal Resource(ResourcePool _resourcePool)
        {
            resourcePool = _resourcePool;

            Console.WriteLine($"Creating Resource {Name} Started ....");
            Thread.Sleep(1000);
            Console.WriteLine($"Creating Resource {Name} Ended");
        }
        public void Dispose()
        {
            resourcePool.AddToPool(this);
        }

    }

}
