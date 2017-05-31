using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Point //class point untuk posisi tower
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int distanceTo (int x, int y)
        {
            int xDiffSquared = (X - x) * (X - x);
            int yDiffSquared = (Y - y) * (Y - y); //Math.pow((Y-y), 2);

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);//parseInt dari nilai Math.sqrt (karna bisa jadi Double)
        }

        public int distanceTo(Point point)
        {
            return distanceTo(point.X, point.Y);
        }
    }
}
