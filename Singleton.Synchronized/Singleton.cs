using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Synchronized
{
    // simple thread-safety
    public sealed class Singleton
    {
        private static Singleton obj;
        private static readonly object lck = new object();
        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                lock(lck)
                {
                    if (obj == null)
                        obj = new Singleton();
                    return obj;
                }
            }
        }
    }
}
