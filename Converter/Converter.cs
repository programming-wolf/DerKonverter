using JetBrains.Annotations;

namespace Der.Konverter
{
    [PublicAPI]
    public static class Converter
    {
        public static long ConvertByteArrayToLong(byte[] array)
        {
            long result = 0;

            if (array != null)
            {
                var i = 0;
                for (; i < 8; i++)
                {
                    result = result << 8;
                    result |= array[i];
                }
            }

            return result;
        }
    }
}
