using System;

namespace Prototype.DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var model = "Renault Logan";
            var prototype = new Car
            {
                Model = model,
                Engine = engine,
                Width = 1.7,
                Length = 4,
                Year = 2004
            };

            var clone = (Car)prototype.Clone();

            if (clone.Engine == engine)
                Console.WriteLine("clone and prototype are using same engine");
            else
                Console.WriteLine("clone and prototype are using distinct engine");

            Console.ReadKey();
        }
    }
}
