using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    public class TnakRobot : Robot
    {
        public override void Attack()
        {
            Console.WriteLine("タンクロボは,キャノン砲を撃った!");
        }
    }

}
