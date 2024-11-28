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

            numbers.Add(-5);
            numbers.Add(-4);
            numbers.Add(-3);
            numbers.Add(-2);
            numbers.Add(-1);
            numbers.Add(+1);
            numbers.Add(+2);
            numbers.Add(+3);
            numbers.Add(+4);
            numbers.Add(+5);
           

            for(int i = 0; i < numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("---");
            //一時停止
            Console.ReadLine();
        }
    }
}
