using KATAHighAndLow;

namespace KATAHighAndLowTests
{
    public class HightAndLowTests
    {
        [Fact]
        public void SomeTest()
        {
            Assert.Equal("542 -214", HighAndLowClass.HighAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"));
        }

        [Fact]
        public void SortTest()
        {
            Assert.Equal("10 -20", HighAndLowClass.HighAndLow("10 2 -1 -20"));
        }

        [Fact]
        public void PlusMinusTest()
        {
            Assert.Equal("1 -1", HighAndLowClass.HighAndLow("1 -1"));
        }

        [Fact]
        public void PlusPlusTest()
        {
            Assert.Equal("1 1", HighAndLowClass.HighAndLow("1 1"));
        }

        [Fact]
        public void MinusMinusTest()
        {
            Assert.Equal("-1 -1", HighAndLowClass.HighAndLow("-1 -1"));
        }

        [Fact]
        public void PlusMinusZeroTest()
        {
            Assert.Equal("1 -1", HighAndLowClass.HighAndLow("1 -1 0"));
        }

        [Fact]
        public void PlusPlusZeroTest()
        {
            Assert.Equal("1 0", HighAndLowClass.HighAndLow("1 1 0"));
        }

        [Fact]
        public void MinusMinusZeroTest()
        {
            Assert.Equal("0 -1", HighAndLowClass.HighAndLow("-1 -1 0"));
        }

        [Fact]
        public void SingleTest()
        {
            Assert.Equal("42 42", HighAndLowClass.HighAndLow("42"));
        }
        
    }
}