using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
