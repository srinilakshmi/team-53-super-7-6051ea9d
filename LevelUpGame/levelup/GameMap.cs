using System.Collections.Generic;
using System.Drawing;

namespace levelup
{
    public class GameMap
    {
        public int Xstart { get; set; } = 0;
        public int Xend { get; set; } = 9;
        public int Ystart { get; set; } = 0;
        public int Yend { get; set; } = 9;
        
        public List<Point> Positions { get; set; }
        public int NumberofPositions { get => Positions.Count; }

        public GameMap()
        {
            List<Point> points = new List<Point>();
            for (int i = Xstart; i <= Xend; i++)
            {
                for (int j = Ystart; j <= Yend; j++)
                {
                    points.Add(new Point(i, j));
                }
            }
            Positions = points;
        }

    }
}