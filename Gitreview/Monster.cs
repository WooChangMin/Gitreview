using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gitreview
{
    internal class Monster
    {
        private int hp;
        private int mp;
        protected string name;

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"{name}이가 데미지를 {damage}만큼 받습니다.");
        }

        public class Slime : Monster
        {
            public Slime()
            {
                this.name = "슬라임";
            }
        }
    }
}
