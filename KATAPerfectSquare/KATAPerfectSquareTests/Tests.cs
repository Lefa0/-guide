using KATAPerfectSquare;

namespace KATAPerfectSquareTests
{
    public class Tests
    {
        [Fact]
        public void ShouldWorkForSomeExamples()
        {
            Assert.False(PerfectSquare.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.True(PerfectSquare.IsSquare(0), "0 is a square number (0 * 0)");
            Assert.False(PerfectSquare.IsSquare(3), "3 isn't a square number");
            Assert.True(PerfectSquare.IsSquare(4), "4 is a square number (2 * 2)");
            Assert.True(PerfectSquare.IsSquare(25), "25 is a square number (5 * 5)");
            Assert.False(PerfectSquare.IsSquare(26), "26 isn't a square number");
        }

        [Fact]
        public static void ShouldWorkForRandomSquareNumbers()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = r.Next(20) + 1;
                Assert.True(PerfectSquare.IsSquare(num * num), $"{num * num} is a square number ({num} * {num})");
            }
        }

    }
}