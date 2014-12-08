using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Bowling.Specflow
{
    [Binding]
    public class BowlingSteps
    {
        private Game _game;

        [Given(@"新しいゲームを始める")]
        public void GivenANewBowlingGame()
        {
            _game = new Game();
        }

        [When(@"すべてガーター")]
        public void WhenAllOfMyBallsAreLandingInTheGutter()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(0);
            }
        }

        [When(@"すべてストライク")]
        public void WhenAllOfMyRollsAreStrikes()
        {
            for (int i = 0; i < 12; i++)
            {
                _game.Roll(10);
            }
        }

        [Then(@"次のスコアになります:(\d+)")]
        public void ThenMyTotalScoreShouldBe(int score)
        {
            Assert.AreEqual(score, _game.Score);
        }

        [When(@"(\d+)本倒した")]
        public void WhenIRoll(int pins)
        {
            _game.Roll(pins);
        }

        [When(@"一投目(\d+)本、二投目(\d+)本倒した")]
        public void WhenIRoll(int pins1, int pins2)
        {
            _game.Roll(pins1);
            _game.Roll(pins2);
        }


        [When(@"(\d+)フレームすべてで、一投目(\d+)本、二投目(\d+)本倒した")]
        public void WhenIRollSeveralTimes2(int rollCount, int pins1, int pins2)
        {
            for (int i = 0; i < rollCount; i++)
            {
                _game.Roll(pins1);
                _game.Roll(pins2);
            }
        }

        [When(@"次のピンを倒した:(.*)")]
        public void WhenIRollTheFollowingSeries(string series)
        {
            foreach (var roll in series.Trim().Split(','))
            {
                _game.Roll(int.Parse(roll));
            }
        }

        [When(@"次の本数を倒した")]
        public void WhenIRoll(Table rolls)
        {
            foreach (var row in rolls.Rows)
            {
                _game.Roll(int.Parse(row["本数"]));
            }
        }

    }
}
