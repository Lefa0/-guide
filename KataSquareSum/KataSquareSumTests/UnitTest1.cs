using KataSquareSum;

namespace KataSquareSumTests
{
    [TestFixture]
    public class Tests
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
                yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
                yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
                yield return new TestCaseData(new int[] { }).Returns(0);
            }
        }

        [Test, TestCaseSource(nameof(sampleTestCases)), Description("Sample Tests")]
        public int SampleTest(int[] n) => SumSquares.SquareSum(n);
    }
}