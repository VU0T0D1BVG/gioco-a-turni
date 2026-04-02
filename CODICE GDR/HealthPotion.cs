namespace GDRCode_
{
    internal class HealthPotion : Items
    {
        public HealthPotion()
        {
            this.Name = "Healt Potion";
            this.Description = "+30 Hp";
        }

        public override void Use(Entity target)
        {
            target.Hp += 30;
        }
    }
}
