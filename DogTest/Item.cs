using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Item
    {
        protected string name;
        public Item(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public virtual void Use()
        {
            Console.WriteLine("{0}を使用した", name);
        }
    }
}
