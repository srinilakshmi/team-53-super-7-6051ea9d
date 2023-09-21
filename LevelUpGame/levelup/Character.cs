using levelup;
using levelup.cli;
namespace levelup
{
    public class Character
    {
        private string name = "";
        private Position currPos;
        private int moveCount;
        private string type;

        public Character()
        {
            this.name = "character";
            currPos = new Position(-1,-1);
            moveCount = 0;
            type = Game.CharTypes.Monk.ToString();
        }
        public Character(Position pos, string type)
        {
            this.name = "character";
            currPos = pos;
            moveCount = 0;
            this.type = type;
        }
        public Character(string name, string type)
        {
            this.name = name;
            currPos = new Position();
            moveCount = 0;
            this.type = type;
        }
        public Character(string name, Position pos, string type)
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
        public String Type 
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
    }
}