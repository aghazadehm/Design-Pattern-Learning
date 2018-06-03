using System;

namespace Prototype.ShallowCopy
{
    internal class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int Year { get; set; }

        internal Car Clone()
        {
            return (Car)this.MemberwiseClone();
        }
    }
}