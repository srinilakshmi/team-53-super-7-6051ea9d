using System.Collections.Generic;

namespace levelup
{
    public class GameMap
    {
        public int Xstart { get; set; } = 0;
        public int Xend { get; set; } = 9;
        public int Ystart { get; set; } = 0;
        public int Yend { get; set; } = 9;
        
        public List<Position> Positions { get; set; }
        public int NumberofPositions { get => Positions.Count; }

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

    }
}