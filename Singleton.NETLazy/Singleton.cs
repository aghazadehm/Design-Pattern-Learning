using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NETLazy
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
