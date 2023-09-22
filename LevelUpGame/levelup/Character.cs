using levelup;
using levelup.cli;
namespace levelup
{
    public class Character
    {
        private string name = "";
        private Position currPos;
        private int moveCount;
        private Game.CharacterType type;

        public Character(string name, Game.CharacterType type)
        {
            this.name = name;
            currPos = new Position();
            moveCount = 0;
            this.type = type;
        }

        public Character(string name, Position position, Game.CharacterType type)
        {
            this.name = name;
            currPos = position;
            moveCount = 0;
            this.type = type;
        }

        public string Name 
        {
            get { return this.name; }
        }

        public Position Position 
        {
            get { return this.currPos; }
        }

        public Game.CharacterType Type 
        {
            get { return this.type; }
        }

        public int MoveCount 
        {
            get { return this.moveCount; }
        }

        public void UpdateCurrentPosition(Position position)
        {
            this.currPos = position;
        }

        public GameController.GameStatus GetGameStatus()
        {
            GameController.GameStatus gameStatus = new GameController.GameStatus();

            gameStatus.characterName = this.Name;
            gameStatus.currentPosition = this.currPos;
            gameStatus.moveCount = this.MoveCount;
            gameStatus.characterType = this.Type;

            return gameStatus;
        }
    }
}