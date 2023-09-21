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
            Assert.IsNotNull(status);
            Assert.AreEqual(status.currentPosition.GetType(), typeof(Position) );
            Assert.AreEqual(status.currentPosition.X, -1);
            Assert.AreEqual(status.currentPosition.Y, -1);
            Assert.AreEqual(status.moveCount,0);
        }
    }
}