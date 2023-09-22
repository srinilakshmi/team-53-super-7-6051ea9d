using NUnit.Framework;
using levelup;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController(new GameMap());
            testObj.CreateCharacter("Test User", Game.CharacterType.Monk);
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            var status = testObj.GetStatus();      
            Assert.IsNotNull(status);
        }

        [Test]
        public void IsGameStartedProperly()
        {  
            string name = "Andrew";
            Game.CharacterType characterType = Game.CharacterType.Monk;
            testObj.CreateCharacter(name, characterType);
            testObj.StartGame();
            var status = testObj.GetStatus(); 
            var gameMap = testObj.GameMap;
            Assert.IsNotNull(gameMap);
            Assert.AreEqual(status.currentPosition.GetType(), typeof(Position) );
            Assert.AreEqual(status.currentPosition.X >= GameMap.Xstart && status.currentPosition.X <= GameMap.Xend, true);
            Assert.AreEqual(status.currentPosition.Y >= GameMap.Ystart && status.currentPosition.Y <= GameMap.Yend, true);
            Assert.AreEqual(status.moveCount,0);
            Assert.AreEqual(status.currentPosition.X, testObj.Character.Position.X);
            Assert.AreEqual(status.currentPosition.Y, testObj.Character.Position.Y);
            Assert.IsNotNull(testObj.GameMap.EndingPosition);
        }

        [Test]
        public void IsCharacterCreated()
        {
            string name = "Andrew";
            Game.CharacterType characterType = Game.CharacterType.Monk;
            testObj.CreateCharacter(name, characterType);
            var character = testObj.Character;
            Assert.IsNotNull(character);
            Assert.AreEqual(character.Name, "Andrew");
            Assert.AreEqual(Game.CharacterType.Monk, character.Type);
        }

        [Test]
        public void IsCharacterPositionBeingSet()
        {
            IsGameStartedProperly();
            var newPosition = new Position(3,4);
            testObj.SetCharacterPosition(newPosition);
            Assert.AreEqual(newPosition.X, testObj.Character.Position.X);
            Assert.AreEqual(newPosition.Y, testObj.Character.Position.Y);
            Assert.AreEqual(newPosition.X, testObj.GetStatus().currentPosition.X);
            Assert.AreEqual(newPosition.Y, testObj.GetStatus().currentPosition.Y);
        }
    }
}