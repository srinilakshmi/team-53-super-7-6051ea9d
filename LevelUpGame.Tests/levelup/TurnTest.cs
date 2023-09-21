using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class TurnTest
    {
        private GameMap gameMap = new GameMap();
        private Turn testObj;
        private List<TurnTestResult> turnResults;

        [SetUp]
        public void SetUp()
        {
            testObj = new Turn();
            turnResults = new List<TurnTestResult>
            {
                new TurnResults (new Position(0, 0), GameController.DIRECTION.NORTH, new Position(0, 1)),
                new TurnResults (new Position(0, 0), GameController.DIRECTION.EAST, new Position(1, 0)),
                new TurnResults (new Position(0, 0), GameController.DIRECTION.WEST, new Position(0, 0)),
                new TurnResults (new Position(0, 0), GameController.DIRECTION.SOUTH, new Position(0, 0)),

                new TurnResults (new Position(0, 9), GameController.DIRECTION.NORTH, new Position(0, 9)),
                new TurnResults (new Position(0, 9), GameController.DIRECTION.EAST, new Position(1, 9)),
                new TurnResults (new Position(0, 9), GameController.DIRECTION.WEST, new Position(0, 9)),
                new TurnResults (new Position(0, 9), GameController.DIRECTION.SOUTH, new Position(0, 8)),

                new TurnResults (new Position(9, 9), GameController.DIRECTION.NORTH, new Position(9, 9)),
                new TurnResults (new Position(9, 9), GameController.DIRECTION.EAST, new Position(9, 9)),
                new TurnResults (new Position(9, 9), GameController.DIRECTION.WEST, new Position(8, 9)),
                new TurnResults (new Position(9, 9), GameController.DIRECTION.SOUTH, new Position(9, 8)),

                new TurnResults (new Position(9, 0), GameController.DIRECTION.NORTH, new Position(9, 1)),
                new TurnResults (new Position(9, 0), GameController.DIRECTION.EAST, new Position(9, 0)),
                new TurnResults (new Position(9, 0), GameController.DIRECTION.WEST, new Position(8, 0)),
                new TurnResults (new Position(9, 0), GameController.DIRECTION.SOUTH, new Position(9, 0)),

                new TurnResults (new Position(5, 5), GameController.DIRECTION.NORTH, new Position(5, 6)),
                new TurnResults (new Position(5, 5), GameController.DIRECTION.EAST, new Position(6, 5)),
                new TurnResults (new Position(5, 5), GameController.DIRECTION.WEST, new Position(4, 5)),
                new TurnResults (new Position(5, 5), GameController.DIRECTION.SOUTH, new Position(5, 4)),
            }
        }

        [Test]
        public void TestLeftBottom()
        {
            foreach(var turnResult in turnResults.Where(t => t.X == 0 && t.Y == 0))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result, turnResult.Result);
            }
        }

        [Test]
        public void TestLeftTop()
        {
            foreach(var turnResult in turnResults.Where(t => t.X == 0 && t.Y == 9))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result, turnResult.Result);
            }
        }

        [Test]
        public void TestRightTop()
        {
            foreach(var turnResult in turnResults.Where(t => t.X == 9 && t.Y == 9))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result, turnResult.Result);
            }
        }

        [Test]
        public void TestRightBottom()
        {
            foreach(var turnResult in turnResults.Where(t => t.X == 9 && t.Y == 0))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result, turnResult.Result);
            }
        }

        [Test]
        public void TestCenter()
        {
            foreach(var turnResult in turnResults.Where(t => t.X == 5 && t.Y == 5))
            {
                var result = testObj.CalculatePosition(turnResult.StartingPosition, turnResult.Direction);
                Assert.AreEqual(result, turnResult.Result);
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