using System.Xml;
using Xunit;


namespace UnitTests
{
    public class ReverseAndAddTests
    {
        [Fact]
        public void ReverseNumberReturnsReversedNumber()
        {
            var input = 382687;

            var result = ReverseAndAdd_6._8._19.Program.ReverseNumber(input);

            Assert.Equal(786283, result);
        }
    }
}

