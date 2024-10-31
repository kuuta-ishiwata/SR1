using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{

    internal class Program
    {
        static void Main(string[] args)
        {

            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");

            Console.WriteLine("名前:{0}", flyingRobot.GetName());
            Console.WriteLine("電源:{0}", flyingRobot.GetPowerStatus());

            flyingRobot.DropBomb();

            flyingRobot.PowerOn();
            flyingRobot.DropBomb();

            flyingRobot.PowerOFF();

            Console.WriteLine("------------");

            //タンクロボットをテストする
            TankRobot tankRobot = new TankRobot("タンクロボット");

            Console.WriteLine("名前:{0}", tankRobot.GetName());
            Console.WriteLine("電源:{0}", tankRobot.GetPowerStatus());

            tankRobot.PowerOn();
            tankRobot.ShootCannon();

            tankRobot.PowerOFF();

            Console.WriteLine("------------");

            //TankRobotクラスの実態を大量生成
            TankRobot[] tanks = new TankRobot[5];

            //TankRobot 5体分の実体を作る
            for(int i = 0; i<tanks.Length;i++)
            {
                tanks[i] = new TankRobot("タンクNo" + i);
            }
            for(int i = 0; i<tanks.Length;i++)
            {
                tanks[i].PowerOn();
            }
            foreach(TankRobot tank in tanks)
            {
                tank.ShootCannon();
            }

            //一時停止
            Console.ReadLine();

        }
    }
}
