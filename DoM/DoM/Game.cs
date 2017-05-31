using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Game
    {
        static void Main(string[] args)
        {
            
            Map map = new Map(8, 5);// ukuran map 8 X 5       
            //Console.WriteLine(map.Height * map.Width);

            //Point point = new Point(4, 2); // X=4, Y=2
            //bool isOnMap = map.onMap(point); //cek apakah point ada di map
            ////Console.WriteLine(isOnMap);

            ////Console.WriteLine(point.distanceTo(5, 2));//x=5, y=2
            //MapLocation point2 = new MapLocation(8, 5, map);
            //isOnMap = map.onMap(point2);
            //Console.WriteLine(isOnMap);
            //Console.WriteLine(point2.distanceTo(7, 5));
            //Console.Read();

            try
            {
                //MapLocation point2 = new MapLocation(7, 4, map);

                Path path = new Path(
                    new[]
                    {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map)
                        //new MapLocation(7, 2, map)
                    });

                Invader[] invaders =
                {
                    new Invader(path),                    
                    new Invader(path),
                    new Invader(path)
                };


                Tower[] towers =
                {
                    new Tower( new MapLocation(1,3,map)),
                    new Tower( new MapLocation(3,3,map)),
                    new Tower( new MapLocation(5,3,map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
                //MapLocation location = path.getLocationAt(8);
                //Console.WriteLine(location.X + "," + location.Y);
            }
            catch (OutOfBoundsException ex)//jika input diluar map
            {
                Console.WriteLine(ex.Message);
            }
            catch (MDException ex)//jika input bukan number
            {
                Console.WriteLine("Exception level 2 " + ex.Message);
            }
            catch (Exception ex)//jika input lebih aneh lagi
            {
                Console.WriteLine("Exception level 3 "+ ex.Message);
            }

            Console.Read();
        }
    }
}
