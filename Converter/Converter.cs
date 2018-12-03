using System;
using JetBrains.Annotations;

namespace Der.Konverter
{
    [PublicAPI]
    public static class Converter
    {
        public static long ConvertByteArrayToLong(byte[] array)
        {
            if (array != null && array.Length > 8)
            {
                throw new ArgumentOutOfRangeException(nameof(array),
                    "Array is larger than eight bytes and cannot be converted to a long value!");
            }

            long result = 0;

            if (array != null)
            {
                var i = 0;
                for (; i < array.Length; i++)
                {
                    result = result << 8;
                    result |= array[i];
                }
            }

            return result;
        }
    }
}
