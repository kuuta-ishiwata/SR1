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
         Item item2;
        public Player(Item item)
        {
            item2 = item;
        }



        public virtual void UseItem()
        {
            item2.Use();
        }

    }
}
