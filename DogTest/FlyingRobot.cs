using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class FlyingRobot : Robot
    {
        public FlyingRobot(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine("空飛ぶロボは,爆弾を落とした");
        }
    }

}
