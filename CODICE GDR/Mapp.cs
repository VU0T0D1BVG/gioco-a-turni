namespace GDRCode_
{
    internal class Mapp
    {
        public Room[] Rooms = new Room[5];

        public Mapp()
        {
            Rooms[0] = new Room(1, new Goblin(), new HealthPotion());
            Rooms[1] = new Room(2, new Orc(), new AttackBoost());
            Rooms[2] = new Room(3, new Troll(), new SpecialCharge());
            Rooms[3] = new Room(4, new Vampire(), new HealthPotion());
            Rooms[4] = new Room(5, new Dragon(), new AttackBoost());
        }

        public Room GetRoom(int index)
        {
            return Rooms[index];
        }
    }


}
