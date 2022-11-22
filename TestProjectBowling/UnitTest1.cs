namespace TestProjectBowling
{
    public class BowlingTests
    {
        private Game _game;
        
        public BowlingTests() 
        {
            _game = new Game(); 
        }

        [Test]
        public void ShouldBe0_ZeroPinsPerBowl()
        {

            MultipleRolls(20, 0);
            Assert.AreEqual(0, _game.GetScore());
        }

        [Test]
        public void ShouldBe20_ScoreOnePinPerThrow()
        {

            MultipleRolls(20, 1);
            Assert.AreEqual(20, _game.GetScore());
        }

        public void MultipleRolls(int bowls,int pins)
        {
            for (int i = 0; i < bowls; i++)
            {
                _game.BowlTheBall(pins);
            }
        }
    }
}