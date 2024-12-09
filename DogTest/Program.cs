using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{

    public class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();
            Random rand = new Random();

            for(int i = 0; i<15;i++)
            {
                if(rand.Next() == 0)
                {
                     robots.Add(new FlyingRobot("爆撃機"));
                }
                else
                {
                    robots.Add(new TnakRobot());
                }

            }

            foreach(var robot in robots)
            {
                robot.Attack();
            }

            //一時停止
            Console.ReadLine();
        }
    }
}
