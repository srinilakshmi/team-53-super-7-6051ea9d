
namespace levelup
{
    public class Character
    {
        private string name = "";
        private Position currPos;
        private int moveCount;

        public Character()
        {
            this.name = "character";
            currPos = new Position(2,2);
            moveCount = 0;
        }
        public Character(Position pos)
        {
            this.name = "character";
            currPos = pos;
            moveCount = 0;
        }
        public Character(string name)
        {
            this.name = name;
            currPos = new Position();
            moveCount = 0;
        }
        public Character(string name, Position pos)
        {
            this.name = name;
            currPos = pos;
            moveCount = 0;
        }

        public string Name 
        {
            get { return this.name; }
        }

        public Position Position 
        {
            get { return this.currPos; }
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