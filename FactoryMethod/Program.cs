using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.CreateShape(ShapeType.Circle);
            var square = shapeFactory.CreateShape(ShapeType.Square);
            var rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);

            circle.Draw();
            square.Draw();
            rectangle.Draw();

            Console.ReadKey();
        }
    }
}
