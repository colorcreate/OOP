using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Map
    {
        public readonly int Height;//atribut map
        public readonly int Width;//atribut map

        public Map (int width, int height)// map as object, section untuk konstruksi object map
        {
            Height = height;
            Width = width;
        }

        public bool onMap (Point point)//atribut yang berupa fungsi (mengecek posisi point, apakah ada di map atau tidak)
        {
            var inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;

            return inBounds;
        }

        //satu kelas saatu object, dan satu solution bisa beberapa object

    }
}
