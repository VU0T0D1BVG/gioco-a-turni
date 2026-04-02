using System;

namespace GDRCode_
{
    internal class IaEnemy
    {
        public void IaChoice(Enemy enemy, Player player, GameMessages messages, Random rnd)
        {
           
            int Probability = rnd.Next(1, 101);

            if (Probability < 80 && enemy.Hp < 15 && enemy.Hp > 0 && enemy.Medikit > 0)
            {
                int recoveredHp = enemy.MakeCure();
                messages.ShowMessageCure(enemy, recoveredHp);
            }
            else if ((Probability <= 50 && player.Hp <=50 && enemy.SpecialAttack > 0) || (Probability <= 50 && player.Medikit == 0))
            {
                int specialDamage = enemy.MakeSpecialAttack(player,rnd);
                messages.ShowSpecialAttackMessage(enemy, player, specialDamage);
            }
            else
            {
                int damage = enemy.MakeAttack(player,rnd);
                messages.ShowAttackMessage(enemy, player, damage);
            }
        }   
    }
}
