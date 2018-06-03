using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Classic
{
    // not thread-safe
    public sealed class Singleton
    {
        private static Singleton obj;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (obj == null)
                obj = new Singleton();
            return obj;
        }
    }
}
