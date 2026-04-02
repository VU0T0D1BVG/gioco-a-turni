using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Goblin : Enemy
    {
        public Goblin()
        {
            this.Name = "Goblin";
            this.Hp = 60;
            this.MaxHp = 60;
            this.AttackMin = 3;
            this.AttackMax = 8;
            this.SpecialAttack = 2;
            this.Medikit = 1;
        }
    }
}
