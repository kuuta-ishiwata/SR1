using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Rectangle : Shape
    {
        private float width;
        private float height;

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;

            area = width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("□");
        }

    }
}
