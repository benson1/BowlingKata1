namespace TestProjectBowling
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldBe0_ZeroPinsPerBowl()
        {
            Game game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.BowlTheBall(0);
            }
            Assert.AreEqual(0, game.GetScore());
        }

        [Test]
        public void ShouldBe20_ScoreOnePinPerThrow()
        {
            Game game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.BowlTheBall(1);
            }
            Assert.AreEqual(20, game.GetScore());
        }
    }
}