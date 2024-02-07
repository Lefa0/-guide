using KataSentenceSmash;

namespace KataSentenceSmashTests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(SentenceSmash.Smash(new string[] { "hello" }), Is.EqualTo("hello"));
            Assert.That(SentenceSmash.Smash(new string[] { "hello", "world" }), Is.EqualTo("hello world"));
            Assert.That(SentenceSmash.Smash(new string[] { "hello", "amazing", "world" }), Is.EqualTo("hello amazing world"));
            Assert.That(SentenceSmash.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }), Is.EqualTo("this is a really long sentence"));
            Assert.That(SentenceSmash.Smash(new string[] { "" }), Is.EqualTo(""));
        }
    }
}