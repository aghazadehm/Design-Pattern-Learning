using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
