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

            Assert.IsNotNull(GameMap.Xstart);

            Assert.IsNotNull(GameMap.Xend);

            Assert.IsNotNull(GameMap.Ystart);

            Assert.IsNotNull(GameMap.Yend);
        }
        
        [Test]
        public void IsNumberofPositionsValid()
        {
            int x = (GameMap.Xend - GameMap.Xstart) + 1;

            int y = (GameMap.Yend - GameMap.Ystart) + 1;

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
            Assert.IsTrue(endPos.X >= GameMap.Xstart && endPos.X <= GameMap.Xend && endPos.Y >= GameMap.Ystart && endPos.Y <= GameMap.Yend);
        }
    }
}