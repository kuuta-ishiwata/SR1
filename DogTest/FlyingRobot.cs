using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    public class FlyingRobot : Robot
    {
        public override void Attack()
        {
            Console.WriteLine("空飛ぶロボは,爆弾を落とした");
        }
    }

}
