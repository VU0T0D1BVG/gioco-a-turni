using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Warrior : Entity
    {
       public Warrior()
        {
            this.Name = "Kratos";
            this.Hp = 100;
            this.MaxHp = 130;
            this.AttackMin = 6;
            this.AttackMax = 12;
            this.SpecialAttack = 3;
            this.Medikit = 2;
        }
        
    }
}
