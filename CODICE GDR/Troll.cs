using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Troll : Enemy
    {
        public Troll()
        {
            this.Name = "Troll";
            this.Hp = 100;
            this.MaxHp = 100;
            this.AttackMin = 7;
            this.AttackMax = 13;
            this.SpecialAttack = 1;
            this.Medikit = 2;
        }
    }
}
