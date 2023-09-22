using NUnit.Framework;
using levelup;
using System.Collections.Generic;
using System.Linq;
using System;

namespace levelup
{
    [TestFixture]
    public class TurnTest
    {
        private GameMap gameMap;
        private Turn testObj;
        private List<TurnTestResult> turnTestResults;

        [SetUp]
        public void SetUp()
        {

        Random rnd = new Random();
        gameMap = new GameMap(new Position(rnd.Next(0, 10), rnd.Next(0, 10)));
            testObj = new Turn(gameMap);
            turnTestResults = new List<TurnTestResult>
            {
                new TurnTestResult (new Position(0, 0), GameController.DIRECTION.NORTH, new Position(0, 1)),
                new TurnTestResult (new Position(0, 0), GameController.DIRECTION.EAST, new Position(1, 0)),
                new TurnTestResult (new Position(0, 0), GameController.DIRECTION.WEST, new Position(0, 0)),
                new TurnTestResult (new Position(0, 0), GameController.DIRECTION.SOUTH, new Position(0, 0)),

                new TurnTestResult (new Position(0, 9), GameController.DIRECTION.NORTH, new Position(0, 9)),
                new TurnTestResult (new Position(0, 9), GameController.DIRECTION.EAST, new Position(1, 9)),
                new TurnTestResult (new Position(0, 9), GameController.DIRECTION.WEST, new Position(0, 9)),
                new TurnTestResult (new Position(0, 9), GameController.DIRECTION.SOUTH, new Position(0, 8)),

                new TurnTestResult (new Position(9, 9), GameController.DIRECTION.NORTH, new Position(9, 9)),
                new TurnTestResult (new Position(9, 9), GameController.DIRECTION.EAST, new Position(9, 9)),
                new TurnTestResult (new Position(9, 9), GameController.DIRECTION.WEST, new Position(8, 9)),
                new TurnTestResult (new Position(9, 9), GameController.DIRECTION.SOUTH, new Position(9, 8)),

                new TurnTestResult (new Position(9, 0), GameController.DIRECTION.NORTH, new Position(9, 1)),
                new TurnTestResult (new Position(9, 0), GameController.DIRECTION.EAST, new Position(9, 0)),
                new TurnTestResult (new Position(9, 0), GameController.DIRECTION.WEST, new Position(8, 0)),
                new TurnTestResult (new Position(9, 0), GameController.DIRECTION.SOUTH, new Position(9, 0)),

                new TurnTestResult (new Position(5, 5), GameController.DIRECTION.NORTH, new Position(5, 6)),
                new TurnTestResult (new Position(5, 5), GameController.DIRECTION.EAST, new Position(6, 5)),
                new TurnTestResult (new Position(5, 5), GameController.DIRECTION.WEST, new Position(4, 5)),
                new TurnTestResult (new Position(5, 5), GameController.DIRECTION.SOUTH, new Position(5, 4)),
            };
        }

        [Test]
        public void TestLeftBottom()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 0 && t.StartingPosition.Y == 0))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                AreEqual(turnResult.Result.ToString(), result.ToString());
            }
        }

        [Test]
        public void TestLeftTop()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 0 && t.StartingPosition.Y == 9))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                AreEqual(turnResult.Result.ToString(), result.ToString());
            }
        }

        [Test]
        public void TestRightTop()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 9 && t.StartingPosition.Y == 9))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                AreEqual(turnResult.Result.ToString(), result.ToString());
            }
        }

        [Test]
        public void TestRightBottom()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 9 && t.StartingPosition.Y == 0))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                AreEqual(turnResult.Result.ToString(), result.ToString());
            }
        }

        [Test]
        public void TestCenter()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 5 && t.StartingPosition.Y == 5))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                AreEqual(turnResult.Result.ToString(), result.ToString());
            }
        }

        private void AreEqual(string expected, string result)
        {
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestIsPositionValid()
        {
            Assert.IsTrue(testObj.IsPositionValid(new Position(GameMap.Xstart, GameMap.Ystart)));
            Assert.IsTrue(testObj.IsPositionValid(new Position(GameMap.Xstart, GameMap.Yend)));
            Assert.IsTrue(testObj.IsPositionValid(new Position(GameMap.Xend, GameMap.Ystart)));
            Assert.IsTrue(testObj.IsPositionValid(new Position(GameMap.Xend, GameMap.Yend)));
            
            var random = new Random();
            var initialX = random.Next(GameMap.Xstart, GameMap.Xend);
            var initialY = random.Next(GameMap.Ystart, GameMap.Yend);
            Assert.IsTrue(testObj.IsPositionValid(new Position(initialX, initialY)));
            
            Assert.IsFalse(testObj.IsPositionValid(new Position(GameMap.Xend + 1, GameMap.Yend)));
            Assert.IsFalse(testObj.IsPositionValid(new Position(GameMap.Xstart - 1, GameMap.Yend)));
            Assert.IsFalse(testObj.IsPositionValid(new Position(GameMap.Xend, GameMap.Yend + 1)));
            Assert.IsFalse(testObj.IsPositionValid(new Position(GameMap.Xend, GameMap.Ystart - 1)));
        }
    }

    public class TurnTestResult
    {
        public TurnTestResult(Position startingPosition, GameController.DIRECTION direction, Position result)
        {
            StartingPosition = startingPosition;
            Direction = direction;
            Result = result;
        }
        public Position StartingPosition { get; set; }
        public GameController.DIRECTION Direction { get; set; }
        public Position Result { get; set; }
    }
}