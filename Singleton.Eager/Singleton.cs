using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Eager
{
    // not quite as lazy, but thread-safe without using locks
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        static Singleton() { }
        private Singleton() { }
        public static Singleton Instance {
            get { return instance; }
        }
    }
}
