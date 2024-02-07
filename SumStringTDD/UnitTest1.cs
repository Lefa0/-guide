using SumString;

namespace SumStringTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Add()
        {
            var num = new Solution();
            var result = num.solution("one+two");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Subtract()
        {
            var num = new Solution();
            var result = num.solution("one-two");
            Assert.Equal(-1, result);
        }

        [Fact]
        public void StartWithNegativeNum()
        {
            var num = new Solution();
            var result = num.solution("-one-two");
            Assert.Equal(-3, result);
        }
    }
}