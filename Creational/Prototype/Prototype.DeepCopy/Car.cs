using System;

namespace Prototype.DeepCopy
{
    public class Car : IPrototype
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double Width { get; set; }
        public int Length { get; set; }
        public int Year { get; set; }

        public IPrototype Clone()
        {
            var car = (Car)this.MemberwiseClone();
            car.Engine = (Engine)Engine.Clone();
            return (IPrototype)car;
        }
    }
}