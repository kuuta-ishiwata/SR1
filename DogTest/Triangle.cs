using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Triangle: Shape
    {
        private float width;
        private float height;

        public Triangle(float width, float height)
        {
            this.width = width;
            this.height = height;

            area = width * height / 2.0f;
        }

        public override void Draw()
        {
            Console.WriteLine("△");
        }

    }
}
