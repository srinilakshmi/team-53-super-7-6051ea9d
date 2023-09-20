using System;
using FluentAssertions;
using levelup;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Linq;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class StartGameSteps
    {
        private GameController testObj = new GameController();

        [When(@"the game is started")]
        public void whenTheGameIsStarted()
        {
            testObj = new GameController();
            testObj.StartGame();
        }

        [Then(@"the Game has (.*) positions")]
        public void checkPositionCount(int numPositions)
        {
            testObj.GetTotalPositions().Should().Be(numPositions);
        }

        [Then(@"the Game sets the character's X position between (.*) and (.*)")]
        public void checkXPosition(int xStart,  int xEnd)
        {
            int[] range = Enumerable.Range(xStart, xEnd).ToArray();
            testObj.GetStatus().currentPosition.X.Should().BeOneOf(range);
        }

        [Then(@"the Game sets the character's Y position between (.*) and (.*)")]
        public void checkYPosition(int yStart, int yEnd)
        {
            int[] range = Enumerable.Range(yStart, yEnd).ToArray();
            testObj.GetStatus().currentPosition.X.Should().BeOneOf(range);
        }

        [Then(@"the move count is(.*)")]
        public void checkMoveCount(int moveCount) {
            testObj.GetStatus().moveCount.Should().Be(moveCount);
        }
    }
}