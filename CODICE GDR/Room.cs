using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Room
    {
        public int RoomNumber;
        public Enemy Enemy;
        public Items Reward;

        public Room(int roomnumber, Enemy enemy, Items reward)
        {
            RoomNumber = roomnumber;
            Enemy = enemy;
            Reward = reward;
        }
    }
}