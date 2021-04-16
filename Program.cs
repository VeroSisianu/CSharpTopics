using System;

namespace Lectia23_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory("Alex's factory", 5498, "Alexei Mateevici 1");
            Factory.Address addressOfFactory = new Factory.Address();
            Console.WriteLine(addressOfFactory.GetAddress(factory));
        }
    }
}
