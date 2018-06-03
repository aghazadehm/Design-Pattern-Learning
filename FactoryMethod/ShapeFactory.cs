using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Circle:
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
