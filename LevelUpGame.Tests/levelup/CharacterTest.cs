using NUnit.Framework;
using levelup;
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
        }
        [Test]
        public void IsCharacterHasAName()
        {
            Assert.IsNotNull(testChar.GetName());
        }

        [Test]
        public void CheckCharacterNameAssignment()
        {
            string name = "Roger";
            Character chr = new Character(name);

            Assert.AreEqual(chr.GetName(), name);
        }

        [Test]
        public void IsCharacterGetPositionReturnsValidPosition()
        {
            var pos = this.testChar.GetCurrentPosition();
            Assert.AreEqual(pos.GetType(), typeof(Position) );
        }

        [Test]
        public void IsCharacterUpdatePositionChangedtoNotNull()
        {
            var posBeforeUpdate = this.testChar.GetCurrentPosition();
            Position newPos = new levelup.Position(posBeforeUpdate.X + 2, posBeforeUpdate.Y+2);
            this.testChar.UpdateCurrentPosition(newPos);
            var posAfterUpdate = this.testChar.GetCurrentPosition();
            Assert.IsNotNull(posAfterUpdate );
        }

        [Test]
        public void IsCharacterUpdatePositionChangedPosition()
        {
            var posBeforeUpdate = this.testChar.GetCurrentPosition();
            Position newPos = new levelup.Position(posBeforeUpdate.X + 2, posBeforeUpdate.Y+2);
            this.testChar.UpdateCurrentPosition(newPos);
            var posAfterUpdate = this.testChar.GetCurrentPosition();
            Assert.AreNotEqual(posBeforeUpdate, posAfterUpdate );
        }

        [Test]
        public void IsCharacterUpdatePositionChangedToGivenPosition()
        {
            var posBeforeUpdate = this.testChar.GetCurrentPosition();
            Position newPos = new levelup.Position(posBeforeUpdate.X + 2, posBeforeUpdate.Y+2);
            this.testChar.UpdateCurrentPosition(newPos);
            var posAfterUpdate = this.testChar.GetCurrentPosition();
            Assert.AreEqual(newPos, posAfterUpdate );
        }

        [Test]
        public void IsMoveCountInitialized()
        {
            Assert.NotNull(this.testChar.GetMoveCount());
        }

        [Test]
        public void IsMoveCountValid()
        {
            Assert.GreaterOrEqual(this.testChar.GetMoveCount(), 0);
        }
    }


}