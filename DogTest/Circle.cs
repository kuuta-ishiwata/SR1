using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DogTest
{
    internal class Circle : Shape
    {
        public float radius;

        public Circle(float radius)
        {
            this.radius = radius;

            area = radius * radius * (float)Math.PI;
        }

        public override void Draw()
        {
            Console.WriteLine("〇");
        }

    }
}
