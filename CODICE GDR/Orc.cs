using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Orc : Enemy
    {
        public Orc()
        {
            this.Name = "Orc";
            this.Hp = 80;
            this.MaxHp = 80;
            this.AttackMin = 5;
            this.AttackMax = 10;
            this.SpecialAttack = 2;
            this.Medikit = 1;
        }
    }
}
