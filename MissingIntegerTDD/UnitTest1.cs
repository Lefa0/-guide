using MissingIntegerExercise;

namespace MissingIntegerTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var arrayA = new[] { 1, 3, 6, 4, 1, 2 };

            var test = new MissingInteger();

            var result = test.Solution(arrayA);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Test2()
        {
            var arrayA = new[] { -1, -2, };

            var test = new MissingInteger();

            var result = test.Solution(arrayA);

            Assert.Equal(1, result);
        }
    }
}