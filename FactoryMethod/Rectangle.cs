using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
