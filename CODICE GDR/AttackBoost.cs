namespace GDRCode_
{
    internal class AttackBoost : Items
    {
        public AttackBoost()
        {
            this.Name = "Attack Boost";
            this.Description = "+3 Attack Max";
        }

        public override void Use(Entity target)
        {
            target.AttackMax += 3;
        }
    }
}
