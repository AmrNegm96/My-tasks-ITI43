namespace ResourcePooling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResourcePool resourcePool = new();

            Resource r1 = resourcePool.getResource();
            r1.UseResource();
            Console.WriteLine($"R01 {r1.GetHashCode()}");
            
            Resource r2 = resourcePool.getResource();
            r2.UseResource();
            Console.WriteLine($"R02 {r2.GetHashCode()}");

            r1.Dispose();

            Resource r3 = resourcePool.getResource();
            r3.UseResource();
            Console.WriteLine($"R03 {r3.GetHashCode()}");

            r1.UseResource();
            Console.WriteLine($"R01 {r1.GetHashCode()}");



            r2.Dispose();

            Resource r4 = resourcePool.getResource();
            Console.WriteLine($"R04 {r4.GetHashCode()}");
        }
    }
}