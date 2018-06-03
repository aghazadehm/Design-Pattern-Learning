using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new ConcretePrototype1("1st Imp.");
            var c1 = p1.Clone();

            var p2 = new ConcretePrototype2("2nd Imp.");
            var c2 = p2.Clone();
        }
    }
}
