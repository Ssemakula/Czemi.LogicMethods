using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Czemi.LogicMethods
{
    public static partial class Logic
    {
        public static byte IfZero(this byte value, byte fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static short IfZero(this short value, short fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static int IfZero(this int value, int fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static long IfZero(this long value, long fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static BigInteger IfZero(this BigInteger value, long fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static double IfZero(this double value, double fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static decimal IfZero(this decimal value, decimal fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static float IfZero(this float value, float fallback = 1)
        {
            return value == 0 ? fallback : value;
        }
    }
}
