using System;

namespace GDRCode_
{
    internal class Entity
    {
        public string Name;
        public int Hp;
        public int MaxHp;
        public int AttackMin;
        public int AttackMax;
        public int SpecialAttack;
        public int Medikit;

        public int MakeAttack(Entity target, Random rnd)
        {
            int damage = rnd.Next(AttackMin, AttackMax);
            target.Hp -= damage;
            return damage;

        }

        public int MakeSpecialAttack(Entity target, Random rnd)
        {
            if (this.SpecialAttack > 0)
            {
                SpecialAttack--;
                int specialDamage = rnd.Next(AttackMin, AttackMax) * 2;
                target.Hp -= specialDamage;
                return specialDamage;

            }
            return 0;
        }

        public int MakeCure()
        {
            if(Medikit > 0)
            {
                int actualyHp = Hp;
                
                Medikit--;
                Hp += 20;

                
                if(Hp > MaxHp)
                {
                    Hp = MaxHp;
                }
                int recoveredhp = Hp - actualyHp;
                return recoveredhp;
            }
            return 0;
        }
    }













}
