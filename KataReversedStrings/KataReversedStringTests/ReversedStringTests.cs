using KataReversedStrings;

namespace KataReversedStringTests
{
    public class ReversedStringTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("dlrow", ReversedStrings.Reverse("world"));
        }
    }
}