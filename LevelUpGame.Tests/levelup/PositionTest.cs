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

        [Test]
        public void ToStringTest()
        {
            Assert.AreEqual("(1,1)",new Position(1,1).ToString());
            Assert.AreEqual("(0,0)",new Position(0,0).ToString());
            Assert.AreNotEqual("(0,0)",new Position(-1,0).ToString());
            Assert.AreNotEqual("(0,0)",new Position(2,3).ToString());
        }

    }
}