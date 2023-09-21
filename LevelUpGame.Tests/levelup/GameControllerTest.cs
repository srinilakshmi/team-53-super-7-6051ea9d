using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            var status = testObj.GetStatus();
            var gameMap = testObj.GameMap;
            Assert.IsNotNull(gameMap);
            Assert.IsNotNull(status);
            Assert.AreEqual(status.currentPosition.GetType(), typeof(Position) );
            Assert.AreEqual(status.currentPosition.X >=0 && status.currentPosition.X <= 9, true);
            Assert.AreEqual(status.currentPosition.Y >=0 && status.currentPosition.Y <= 9, true);
            Assert.AreEqual(status.moveCount,0);
        }
    }
}