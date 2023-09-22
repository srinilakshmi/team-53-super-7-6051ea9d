using NUnit.Framework;
using levelup;
using levelup.cli;
using System;

namespace levelup
{
    [TestFixture]
    public class MoveActionTest
    {

        private MoveAction? testMoveAction;

        [SetUp]
        public void SetUp()
        {
            testMoveAction  = new MoveAction(new levelup.Position(0,0), GameController.DIRECTION.EAST, new levelup.Position(0, 0), Game.MoveActionResult.Bounce);
        } 
            
        [Test]
        public void IsMoveActionNotNull()
        {
            Assert.IsNotNull(testMoveAction);
        }

                [Test]
        public void IsMoveActionInitializedl()
        {
            Assert.IsNotNull(testMoveAction);
            Assert.AreEqual(typeof(levelup.Position), testMoveAction.StartingPosition.GetType());
            Assert.AreEqual(typeof(GameController.DIRECTION), testMoveAction.Direction.GetType());
            Assert.AreEqual(typeof(levelup.Position), testMoveAction.EndingPosition.GetType());
            Assert.AreEqual(typeof(Game.MoveActionResult), testMoveAction.MoveActionResult.GetType());

        }

    }
}