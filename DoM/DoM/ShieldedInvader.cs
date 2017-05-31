using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class ShieldedInvader : Invader
    {
        public static Random _random = new Random();
        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void decreaseHealth(int factor)
        {
            if (_random.NextDouble()>0.5)
                base.decreaseHealth(factor);
        }
    }
}
