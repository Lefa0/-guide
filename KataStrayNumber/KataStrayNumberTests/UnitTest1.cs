using KataStrayNumber;

namespace KataStrayNumberTests
{
    public class UnitTest1
    {
        [Fact]
        public void SimpleArray()
        {
            Assert.Equal(2, StrayNumber.Stray(new int[] { 1, 1, 2 }));
        }
    }
}