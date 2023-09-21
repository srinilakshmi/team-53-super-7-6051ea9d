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
                Assert.AreEqual(result.ToString(), turnResult.Result.ToString());
            }
        }

        [Test]
        public void TestLeftTop()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 0 && t.StartingPosition.Y == 9))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result.ToString(), turnResult.Result.ToString());
            }
        }

        [Test]
        public void TestRightTop()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 9 && t.StartingPosition.Y == 9))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result.ToString(), turnResult.Result.ToString());
            }
        }

        [Test]
        public void TestRightBottom()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 9 && t.StartingPosition.Y == 0))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result.ToString(), turnResult.Result.ToString());
            }
        }

        [Test]
        public void TestCenter()
        {
            foreach(var turnResult in turnTestResults.Where(t => t.StartingPosition.X == 5 && t.StartingPosition.Y == 5))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result.ToString(), turnResult.Result.ToString());
            }
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