using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{

    internal class Player
    {
        //フィールド
        private string name;
        private int level;

        //メソッド
        //コンストラクタ
        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        //攻撃
        public void Atttack()
        {
            Console.WriteLine("攻撃!!");
        }

        //防御
        public void Defense()
        {
            Console.WriteLine("防御した");
        }

        //レベルアップ
        public void LevelUp()
        {
            level++;
        }
        //名前を書く
        public string GetName()
        {
            return name;
        }
        //レベルを書く
        public int GetLevel()
        {
            return level;
        }

    }
}
