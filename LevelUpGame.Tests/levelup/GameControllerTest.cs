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
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            var status = testObj.GetStatus();      
            Assert.IsNotNull(status);
            
        }
        public void IsGameStartedProperly()
        {
            var status = testObj.GetStatus();   
            Assert.IsNotNull(status);
            testObj.StartGame();
            var gameMap = testObj.GameMap;
            Assert.IsNotNull(gameMap);
            Assert.AreEqual(status.currentPosition.GetType(), typeof(Position) );
            Assert.AreEqual(status.currentPosition.X >= GameMap.Xstart && status.currentPosition.X <= GameMap.Xend, true);
            Assert.AreEqual(status.currentPosition.Y >= GameMap.Ystart && status.currentPosition.Y <= GameMap.Yend, true);
            Assert.AreEqual(status.moveCount,0);
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
    }
}