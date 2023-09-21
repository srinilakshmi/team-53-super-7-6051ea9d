namespace levelup
{
    public class Turn
    {
        private GameMap gameMap;

        public Turn(GameMap gameMap)
        {
            this.gameMap = gameMap;
        }

        public Position CalculatePosition(Position startingPosition, GameController.DIRECTION direction)
        {
            int x = startingPosition.X;
            int y = startingPosition.Y;
            switch (direction)
            {
                case GameController.DIRECTION.NORTH:
                    y++;
                    break;
                case GameController.DIRECTION.EAST:
                    x++;
                    break;
                case GameController.DIRECTION.WEST:
                    x--;
                    break;
                case GameController.DIRECTION.SOUTH:
                    y--;
                    break;
                default:
                    break;
            }
            var newPosition = new Position(x, y);
            if(IsPositionValid(newPosition))
            {
                return newPosition;
            }
            else
            {
                return startingPosition;
            }
        }

        public bool IsPositionValid(Position position)
        {
           return gameMap.Positions.Any(p => p.X == position.X && p.Y == position.Y);
        }
    }
}