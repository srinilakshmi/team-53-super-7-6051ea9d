using System;
using FluentAssertions;
using levelup;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class CreateCharacterSteps
    {
        private GameController testObj = new GameController();

        private String characterName = "";
        levelup.cli.Game.CharacterType characterType;

        [Given(@"the player supplies the name (.*) and character type as (.*)")]
        public void GivenTheCharactersNameIs(string characterNameInput, levelup.cli.Game.CharacterType characterType)
        {
            this.characterName = characterNameInput;
            this.characterType = characterType;
        }

        [When(@"the character is created")]
        public void whenThePlayerSetsTheirName()
        {
            testObj = new GameController();
            testObj.CreateCharacter(characterName, characterType);
        }
        
        [Then(@"the Game sets the character name to (.*)")]
        public void ThenTheResultShouldBe(string characterNameOutput)
        {
            testObj.GetStatus().characterName.Should().Be(characterNameOutput);
        }
    }
}