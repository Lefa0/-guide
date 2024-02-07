using KATACockroachSpeed;

namespace KATACockroachTDD
{
    public class CockroachTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(30, Cockroaches.CockroachSpeed(1.08));
            Assert.Equal(30, Cockroaches.CockroachSpeed(1.09));
            Assert.Equal(0, Cockroaches.CockroachSpeed(0));
        }
    }
}