using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Vampire : Enemy
    {
        public Vampire()
        {
            this.Name = "Vampire";
            this.Hp = 90;
            this.MaxHp = 90;
            this.AttackMin = 6;
            this.AttackMax = 14;
            this.SpecialAttack = 3;
            this.Medikit = 1;
        }
    }
}
