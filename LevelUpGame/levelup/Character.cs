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

        public Character()
        {
            this.name = "character";
            currPos = new Position(-1,-1);
            moveCount = 0;
            type = Game.CharacterType.Monk;
        }
        public Character(Position pos, Game.CharacterType type)
        {
            this.name = "character";
            currPos = pos;
            moveCount = 0;
            this.type = type;
        }
        public Character(string name, Game.CharacterType type)
        {
            this.name = name;
            currPos = new Position();
            moveCount = 0;
            this.type = type;
        }
        public Character(string name, Position pos, Game.CharacterType type)
        {
            this.name = name;
            currPos = pos;
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

        public void UpdateCurrentPosition(Position pos)
        {
            this.currPos = pos;
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