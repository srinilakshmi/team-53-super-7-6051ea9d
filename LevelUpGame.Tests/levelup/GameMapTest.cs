using NUnit.Framework;
using levelup;
using System.Linq.Expressions;
using System;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap testObj;

        [SetUp]
        public void SetUp()
        {
            Random rnd = new Random();
            testObj = new GameMap(new Position(rnd.Next(0, 10), rnd.Next(0, 10)));
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

        [Test]
        public void ChkNullEndingPosition()
        {           
           Assert.IsNotNull(testObj.EndingPosition);
        }

        [Test]
        public void IsEndingPositionValid()
        {           
            Position endPos = testObj.EndingPosition;
            Assert.IsTrue( endPos.X >= testObj.Xstart && endPos.X <= testObj.Xend && endPos.Y >= testObj.Ystart && endPos.Y <= testObj.Yend);
        }
    }
}