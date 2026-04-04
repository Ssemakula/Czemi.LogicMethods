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

        public static byte IfZero(this byte? value, byte fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static sbyte IfZero(this sbyte value, sbyte fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static sbyte IfZero(this sbyte? value, sbyte fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static short IfZero(this short value, short fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static short IfZero(this short? value, short fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static ushort IfZero(this ushort value, ushort fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static ushort IfZero(this ushort? value, ushort fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static int IfZero(this int value, int fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static int IfZero(this int? value, int fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static uint IfZero(this uint value, uint fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static uint IfZero(this uint? value, uint fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static long IfZero(this long value, long fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static long IfZero(this long? value, long fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static ulong IfZero(this ulong value, ulong fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static ulong IfZero(this ulong? value, ulong fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static BigInteger IfZero(this BigInteger value, long fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static BigInteger IfZero(this BigInteger? value, long fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static double IfZero(this double value, double fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static double IfZero(this double? value, double fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static decimal IfZero(this decimal value, decimal fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static decimal IfZero(this decimal? value, decimal fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }

        public static float IfZero(this float value, float fallback = 1)
        {
            return value == 0 ? fallback : value;
        }

        public static float IfZero(this float? value, float fallback = 1)
        {
            return value == null || value == 0 ? fallback : value.Value;
        }
    }
}
