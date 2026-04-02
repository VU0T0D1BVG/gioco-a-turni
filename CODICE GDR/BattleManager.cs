using System;

namespace GDRCode_
{
    internal class BattleManager
    {
        public int ChoicePlayer(Entity player, Entity enemy, Random rnd, GameMessages message)
        {
            Console.WriteLine("choice the action:\ntaste 1: Attack\ntaste 2: Special Attack\ntaste 3: Medikit");
            int choice;


            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 3))
            {
                Console.WriteLine("Taste NOT VALID, please again...");
            }

            switch (choice)
            {
                case 1:
                    int damage = player.MakeAttack(enemy, rnd);
                    message.ShowAttackMessage(player, enemy, damage);
                    break;

                case 2:
                    int specialDamage = player.MakeSpecialAttack(enemy, rnd);
                    if (specialDamage == 0) message.ShowNoConsumables(player);
                    else { message.ShowSpecialAttackMessage(player, enemy, specialDamage);}
                        break;

                case 3:
                    int recoveredHp = player.MakeCure();
                    if (recoveredHp == 0) message.ShowNoConsumables(player);
                    else { message.ShowMessageCure(player, recoveredHp); }
                    break;
            }
            return choice;


        }

        public void LoopGame(Player player, Enemy enemy, Random rnd, GameMessages messages, IaEnemy ia)
        {
            while (player.Hp > 0 && enemy.Hp > 0)
            {
                Console.Clear();

                messages.ShowStats(player, enemy);

                ChoicePlayer(player, enemy, rnd, messages);

                ia.IaChoice(enemy, player, messages, rnd);

                Console.WriteLine("Think about your next move and press a key to continue...");

                Console.ReadLine();
            }
            messages.ShowWinner(player, enemy);

        }

    }
}
