using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Robot
    {
        //フィールド
        protected string name = "";
        protected bool powerStatus = false;

        //メソッド
        //電源をonにする
        public void PowerOn()
        {
            powerStatus = true;
            Console.WriteLine("{0}は、起動した!!", name);
        }

        //電源をOFFにする
        public void PowerOFF()
        {
            powerStatus = false;
            Console.WriteLine("{0}は、停止した", name);
        }
        //名前を取得する
        public string GetName()
        {
            return name;
        }

        //電源On状態を取得する
        public bool GetPowerStatus()
        {
            return powerStatus;
        }
    }
}
