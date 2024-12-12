﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class TnakRobot : Robot
    {
        public TnakRobot(string name) : base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("{0}は、キャノン砲を撃った!",name);
        }
    }

}
