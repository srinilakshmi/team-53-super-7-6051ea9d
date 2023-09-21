
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
            currPos = new Position();
            moveCount = 0;
        }
        public Character(string name)
        {
            this.name = name;
            currPos = new Position();
            moveCount = 0;
        }

        public string GetName()
        {
            return this.name;
        }

        public Position GetCurrentPosition()
        {
            return this.currPos;
        }

        public int GetMoveCount()
        {
            return this.moveCount;
        }
    }
}