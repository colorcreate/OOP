using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map): base(x, y)
        {
            if (!map.onMap(this))
            {
                throw new OutOfBoundsException("gak ada pointnya");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return distanceTo(location) <= range;
        }
    }
}
