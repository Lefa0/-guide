using KATACountDivisors;

namespace KATACountDivisorsTests
{
    public class CountDivisorsTets
    {
        [Fact]
        public void Tests()
        {
            Assert.Equal(1, CountDivisors.Divisors(1));
            Assert.Equal(4, CountDivisors.Divisors(10));
            Assert.Equal(8, CountDivisors.Divisors(54));
            Assert.Equal(2, CountDivisors.Divisors(11));
        }
    }
}