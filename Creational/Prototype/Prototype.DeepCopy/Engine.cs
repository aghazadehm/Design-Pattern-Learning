using System;

namespace Prototype.DeepCopy
{
    public class Engine : IPrototype
    {
        public Engine()
        {
        }

        public IPrototype Clone()
        {
            return (IPrototype) this.MemberwiseClone();
        }
    }
}