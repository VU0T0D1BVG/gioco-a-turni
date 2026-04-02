using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class GameMessages
    {
        public void ShowStats(Entity e1, Entity e2)
        {
            Console.WriteLine($"Stats {e1.Name}:\nHp: {e1.Hp}\nSpecial Attack: {e1.SpecialAttack}\nMedikit: {e1.Medikit}\n");
            Console.WriteLine($"Stats {e2.Name}:\nHp: {e2.Hp}\nSpecial Attack: {e2.SpecialAttack}\nMedikit: {e2.Medikit}\n");
        }
        public void ShowAttackMessage(Entity attacker, Entity target, int damage)
        {
            Console.WriteLine($"{attacker.Name} ATTACK {target.Name} with damage {damage}\n");
        }
        public void ShowSpecialAttackMessage(Entity attacker, Entity target, int damage)
        {
            
            Console.WriteLine($"{attacker.Name} using SPECIAL ATTACK on {target.Name} with damage {damage}\n");
        }

        public void ShowMessageCure(Entity target, int recoveredHp)
        {
           
            Console.WriteLine($"{target.Name} using a MEDIKIT, Hp recovered: {recoveredHp}\n");
        }

        public void ShowWinner(Entity player, Entity enemy)
        {
            if(player.Hp <= 0) Console.WriteLine($"{enemy.Name} is WINNER");
            else if (enemy.Hp <= 0) Console.WriteLine($"{player.Name} is WINNER"); 
        }

        public void ShowNoConsumables(Entity player)
        {
            if(player.SpecialAttack <= 0)
            {
                Console.WriteLine("SPECIAL ATTACK TERMINATE !!!\n");
            }
            if(player.Medikit <= 0)
            {
                Console.WriteLine("MEDIKIT TERMINATE !!!\n");
            }
        }


    }
}
