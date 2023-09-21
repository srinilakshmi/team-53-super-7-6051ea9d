using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
        }

        [Test]
        public void IsGameMapInitialized()
        {
            Assert.IsNotNull(testObj);

            Assert.IsNotNull(testObj.Xstart);

            Assert.IsNotNull(testObj.Xend);

            Assert.IsNotNull(testObj.Ystart);

            Assert.IsNotNull(testObj.Yend);
        }
        
        [Test]
        public void IsNumberofPositionsValid()
        {
            int x = (testObj.Xend - testObj.Xstart) + 1;

            int y = (testObj.Yend - testObj.Ystart) + 1;

            Assert.IsTrue(testObj.NumberofPositions == (x*y));

        }
    }
}