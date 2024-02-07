using TwoToOneKata;

namespace TowToOneTDD
{
    public class TwoToOneTests
    {
        [Fact]
        public static void Test1()
        {
            Assert.Equal("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.Equal("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.Equal("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}