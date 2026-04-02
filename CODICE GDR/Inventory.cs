using System;

namespace GDRCode_
{
    internal class Inventory
    {

        public Items[] items = new Items[5];

        public void AddItem(Items item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;

                    break;
                }
                
            }
        }

        public void UseItem(int index, Entity target)
        {
            items[index].Use(target);
            items[index] = null;
        }
        public void ShowInventory()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine($"{i + 1} {items[i].Name}: {items[i].Description}");
                }
            }
        }

    }
}
