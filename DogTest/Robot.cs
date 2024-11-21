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
        protected string name;
        //メソッド
        //電源をonにする
        public Robot(string name)
        {
            this.name = name;
        }
        //電源をOFFにする
        //名前を取得する
        public string GetName()
        {
            return name;
        }
        //電源On状態を取得する
        public virtual void Attack()
        {
            Console.WriteLine("{0}は、攻撃した!",name);
        }
    }
}
