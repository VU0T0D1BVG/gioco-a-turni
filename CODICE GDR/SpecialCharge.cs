using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class SpecialCharge : Items
    {
        public SpecialCharge()
        {
            this.Name = "Special Charge";
            this.Description = "+2 Special Attack";
        }

        public override void Use(Entity target)
        {
            target.SpecialAttack += 2;
        }
    }
}
