using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Dragon : Enemy
    {
        public Dragon()
        {
            this.Name = "Dragon";
            this.Hp = 150;
            this.MaxHp = 150;
            this.AttackMin = 10;
            this.AttackMax = 20;
            this.SpecialAttack = 5;
            this.Medikit = 2;
        }
    }
}
