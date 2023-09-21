using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position();
        }

        [Test]
        public void IsPositionInitialized()
        {
            Assert.AreEqual(testObj.X, -1);
            Assert.AreEqual(testObj.Y, -1);
        }
        
        
        [Test]
        public void IsPositionWithCoordinatesInitialized()
        {
            Position testPosition = new Position(0,0);
            Assert.IsNotNull(testPosition);
            Assert.AreEqual(testPosition.X, 0);
            Assert.AreEqual(testPosition.Y, 0);

        } 
    }
}