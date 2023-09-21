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
            #pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testChar);
        }
        [Test]
        public void IsCharacterHasAName()
        {
            Assert.IsNotNull(testChar.GetName());
        }

        [Test]
        public void IsCharacterGetPositionReturnsValidPosition()
        {
            var pos = this.testChar.GetCurrentPosition();
            Assert.AreEqual(pos.GetType(), typeof(Position) );
        }
        [Test]
        public void IsCharacterUpdatePositionChangedPosition()
        {
            Position pos = new Position()
            var posBeforeUpdate = this.testChar.GetCurrentPosition();
            this.testChar.UpdateCurrentPosition();
            Assert.AreEqual(pos.GetType(), typeof(Position) );
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