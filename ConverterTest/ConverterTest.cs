using Der.Konverter;
using NUnit.Framework;

namespace ConverterTest
{
    [TestFixture]
    public class ConverterTest
    {
        [TestCase(2831, new byte[] {0, 0, 0, 0, 11, 15, 22, 17})]
        [TestCase(288230376337249809, new byte[] {4, 0, 0, 0, 11, 15, 22, 17})]
        [TestCase(0, null)]
        public void ConvertByteArrayToLong(long number, byte[] numberAsByteArray)
        {
            Assert.That(Converter.ConvertByteArrayToLong(numberAsByteArray), Is.EqualTo(number));
        }
    }
}
