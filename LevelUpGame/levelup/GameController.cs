using System;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        private Character character;

        public GameMap GameMap{get; }

        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Position currentPosition,
            int moveCount
            );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            GameMap = new GameMap();
            var random = new System.Random();
            var x = random.Next(0,10);
            var y = random.Next(0,10);
            status.currentPosition = new Position(x, y);
            status.moveCount = 0;
        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name, levelup.cli.Game.CharacterType characterType)
        {
            this.status.characterName = string.IsNullOrEmpty(name)?DEFAULT_CHARACTER_NAME: name;
            if(characterType == null)
            {
                characterType = levelup.cli.Game.CharacterType.Monk;
            }
            character = new Character(this.status.characterName, characterType);
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create positions and put the character on one
            // TODO: Should also update the game status?
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
        }

        public void SetCharacterPosition(Position coordinates)
        {
            //TODO: IMPLEMENT THIS TO SET CHARACTERS CURRENT POSITION -- exists to be testable
        }

        public void SetCurrentMoveCount(int moveCount)
        {
            //TODO: IMPLEMENT THIS TO SET CURRENT MOVE COUNT -- exists to be testable
        }

        public int GetTotalPositions()
        {
            //TODO: IMPLEMENT THIS TO GET THE TOTAL POSITIONS FROM THE MAP -- exists to be testable
            return -10;
        }


    }
}