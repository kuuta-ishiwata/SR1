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
            List<int> numbers = new List<int>();

            Random random = new Random(Environment.TickCount);
            

            for(int i  = 0;  i<10;i++)
            {
                numbers.Add(random.Next(-5,5+1));
            }

           
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //一時停止
            Console.ReadLine();
        }
    }
}
