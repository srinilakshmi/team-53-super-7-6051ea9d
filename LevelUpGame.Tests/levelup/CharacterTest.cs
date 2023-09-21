using NUnit.Framework;
using levelup;
using levelup.cli;
using System;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testChar;

        [SetUp]
        public void SetUp()
        {
            testChar  = new Character();
        } 
            
        [Test]
        public void IsCharacterCreated()
        {
            Assert.IsNotNull(testChar);
            Assert.AreEqual(testChar.Position.X, -1);
            Assert.AreEqual(testChar.Position.Y, -1);
        }
        [Test]
        public void IsCharacterHasAName()
        {
            Assert.IsNotNull(testChar.Name);
        }

        [Test]
        public void CheckCharacterNameAssignment()
        {
            string name = "Roger";
            Character chr = new Character(name, Game.CharacterType.BlackKnight);

            Assert.AreEqual(chr.Name, name);
        }

        [Test]
        public void IsCharacterGetPositionReturnsValidPosition()
        {
            var pos = this.testChar.Position;
            Assert.AreEqual(pos.GetType(), typeof(Position) );
        }

        [Test]
        public void IsCharacterUpdatePositionChangedtoNotNull()
        {
            var posBeforeUpdate = this.testChar.Position;
            Position newPos = new levelup.Position(posBeforeUpdate.X + 2, posBeforeUpdate.Y+2);
            this.testChar.UpdateCurrentPosition(newPos);
            var posAfterUpdate = this.testChar.Position;
            Assert.IsNotNull(posAfterUpdate );
        }

        [Test]
        public void IsCharacterUpdatePositionChangedPosition()
        {
            var posBeforeUpdate = this.testChar.Position;
            Position newPos = new levelup.Position(posBeforeUpdate.X + 2, posBeforeUpdate.Y+2);
            this.testChar.UpdateCurrentPosition(newPos);
            var posAfterUpdate = this.testChar.Position;
            Assert.AreNotEqual(posBeforeUpdate, posAfterUpdate );
        }

        [Test]
        public void IsCharacterUpdatePositionChangedToGivenPosition()
        {
            var posBeforeUpdate = this.testChar.Position;
            Position newPos = new levelup.Position(posBeforeUpdate.X + 2, posBeforeUpdate.Y+2);
            this.testChar.UpdateCurrentPosition(newPos);
            var posAfterUpdate = this.testChar.Position;
            Assert.AreEqual(newPos, posAfterUpdate );
        }

        [Test]
        public void IsMoveCountInitialized()
        {
            Assert.NotNull(this.testChar.MoveCount);
        }

        [Test]
        public void IsMoveCountValid()
        {
            Assert.GreaterOrEqual(this.testChar.MoveCount, 0);
        }

        [Test]
        public void IsCharacterTypeNotNull()
        {
            Assert.NotNull(testChar.Type);
        }
    }


}