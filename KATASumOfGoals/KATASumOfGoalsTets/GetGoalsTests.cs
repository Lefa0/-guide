using KATASumOfGoals;

namespace KATASumOfGoalsTets
{
    public class GetGoalsTests
    {
        [Fact]
        public void NoGoals()
        {
            Assert.Equal(0, KATAGoals.GetGoals(0, 0, 0));
        }

        [Fact]
        public void FiftyEightGoals()
        {
            Assert.Equal(58, KATAGoals.GetGoals(43, 10, 5));
        }
    }
}