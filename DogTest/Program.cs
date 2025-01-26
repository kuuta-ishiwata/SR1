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
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(10.0f));
            shapes.Add(new Rectangle(5.0f, 7.0f));
            shapes.Add(new Triangle(5.0f, 7.0f));
            foreach(Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine("面積:{0}", shape.Area());
            }
            //一時停止
            Console.ReadLine();
        }
    }
}
