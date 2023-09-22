using System;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        private Character character;

        public Character Character
        {
            get
            {
                return character;
            }
        }

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
        }

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
            var random = new System.Random();
            var initialX = random.Next(GameMap.Xstart, GameMap.Xend);
            var initialY = random.Next(GameMap.Ystart, GameMap.Yend);
            this.status.currentPosition = new Position(initialX, initialY);
            this.status.moveCount = 0;

        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
            Turn turn = new Turn(this.GameMap);
            Position newPos = turn.CalculatePosition(this.character.Position, directionToMove);
            if(turn.IsPositionValid(newPos))
            {
                //Update Game status
                //Update Character
            }

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