using levelup;
using levelup.cli;
namespace levelup
{
    public class MoveAction
    {
        private levelup.Position startingPosition;
        private GameController.DIRECTION direction;
        private levelup.Position endingPosition;
        private Game.MoveActionResult moveActionResult;

        public levelup.Position StartingPosition 
        {
            get { return this.startingPosition; }
        }

        public GameController.DIRECTION Direction 
        {
            get { return this.direction; }
        }

        public levelup.Position EndingPosition 
        {
            get { return this.endingPosition; }
        }

        public Game.MoveActionResult MoveActionResult 
        {
            get { return this.moveActionResult; }
        }

        public MoveAction(Position startingPosition,  GameController.DIRECTION direction, Position endingPosition, Game.MoveActionResult moveActionResult)
        {
            this.startingPosition = startingPosition;
            this.direction = direction;
            this.endingPosition = endingPosition;
            this.moveActionResult = moveActionResult;
        }
    }
}