using System;
using levelup.cli;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        private Character character;
        private GameMap gameMap;
        private List<MoveAction> gameHistory;
        private int moveCount;
    
        public GameMap GameMap { get => gameMap;}
        public Character Character { get => character;}

        public record struct GameStatus(
            String characterName,
            Position currentPosition,
            int moveCount,
            Game.CharacterType characterType
            );

        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        public List<MoveAction> GameHistory { get => gameHistory;}

        Turn turn;

        public GameController(GameMap gamemap)
        {
            gameHistory = new List<MoveAction>();
        }

        public void CreateCharacter(String name, levelup.cli.Game.CharacterType characterType)
        {
            string characterName = string.IsNullOrEmpty(name)?DEFAULT_CHARACTER_NAME: name;
            if(characterType == null)
            {
                characterType = levelup.cli.Game.CharacterType.Monk;
            }
            character = new Character(characterName, characterType);
        }

        public void SetCurrentMoveCount(int count)
        {
            moveCount = count;
        }

        public void StartGame()
        {
            var random = new System.Random();
            var initialX = random.Next(GameMap.Xstart, GameMap.Xend);
            var initialY = random.Next(GameMap.Ystart, GameMap.Yend);
            character.UpdateCurrentPosition(new Position(initialX, initialY));
            var endX = random.Next(GameMap.Xstart, GameMap.Xend);
            var endY = random.Next(GameMap.Ystart, GameMap.Yend);
            gameMap = new GameMap(new Position(endX, endY));
            turn = new Turn(gameMap);
            
        }

        public GameStatus GetStatus()
        {
            var gameStatus = character.GetGameStatus();
            gameStatus.moveCount = gameHistory.Count;
            return gameStatus;
        }

        public MoveAction Move(DIRECTION directionToMove)
        {
            Position startingPosition = this.character.Position;
            Position newPosition = turn.CalculatePosition(startingPosition, directionToMove);
            SetCharacterPosition(newPosition);
            Game.MoveActionResult moveActionResult;
            if(startingPosition.ToString() == newPosition.ToString())
            {
                moveActionResult = Game.MoveActionResult.Bounce;
            }
            else if(newPosition.ToString() == gameMap.EndingPosition.ToString())
            {
                moveActionResult = Game.MoveActionResult.Winner;
            }
            else
            {
                moveActionResult = Game.MoveActionResult.Success;
            }
            MoveAction moveAction = new MoveAction
            (
                startingPosition,
                directionToMove,
                newPosition,
                moveActionResult
            );
            gameHistory.Add(moveAction);
            return moveAction;
        }

        public void SetCharacterPosition(Position newPosition)
        {
            character.UpdateCurrentPosition(newPosition);
        }

        public int GetTotalPositions()
        {
            return gameMap.NumberofPositions;
        }


    }
}