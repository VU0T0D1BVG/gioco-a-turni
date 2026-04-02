using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDRCode_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();
            GameMessages messages = new GameMessages();
            BattleManager battleManager = new BattleManager();
            Random random = new Random();
            IaEnemy ia = new IaEnemy();
            Inventory inventory = new Inventory();
            Mapp mapp = new Mapp();
            

            for (int i = 0; i < mapp.Rooms.Length; i++)
            {
                mapp.GetRoom(i);
                switch (mapp.Rooms[i])
                {
                    case 0: 
                }
            }


           
            


            
            


            
        }
    }
}
