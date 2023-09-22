using System.Collections.Generic;

namespace levelup
{
    public class GameMap
    {
        public static int Xstart { get; } = 0;
        public static int Xend { get; } = 9;
        public static int Ystart { get; } = 0;
        public static int Yend { get; } = 9;
        
        public List<Position> Positions { get; set; }
        public int NumberofPositions { get => Positions.Count; }

        public readonly Position EndingPosition;

        public GameMap()
        {
            List<Position> points = new List<Position>();
            for (int i = Xstart; i <= Xend; i++)
            {
                for (int j = Ystart; j <= Yend; j++)
                {
                    points.Add(new Position(i, j));
                }
            }
            Positions = points;
        }
        
        public GameMap(Position endingPosition)
        {
            List<Position> points = new List<Position>();
            for (int i = Xstart; i <= Xend; i++)
            {
                for (int j = Ystart; j <= Yend; j++)
                {
                    points.Add(new Position(i, j));
                }
            }
            Positions = points;
            this.EndingPosition = endingPosition;
        }
    }
}