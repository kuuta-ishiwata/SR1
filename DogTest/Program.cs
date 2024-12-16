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
            Player player = new Player(new Item("こん棒"));
             player.UseItem();
            //一時停止
            Console.ReadLine();
        }
    }
}
