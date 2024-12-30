using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{

    internal class Player
    {
        List<Item> items = new List<Item>();
        public Player()
        {
            items = new List<Item>();
        }

        public virtual void AddItem(Item item)
        {
            items.Add(item);
        }


        public  void UseItem()
        {
            items[0].Use();
            items[1].Use();
            items[2].Use();
        }

    }
}
