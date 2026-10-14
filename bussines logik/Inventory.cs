using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussines_logik
{
    public class Inventory
    {
        public List<Item> Items;
        public int Capacity;

        public Inventory(int capacity = 10)
        {
            Capacity = capacity;
            Items = new List<Item>();
        }

        public bool AddItem(Item item)
        {
            if (item == null)
            {
                return false;
            }

            if (Items.Count >= Capacity)
            {
                return false;
            }

            Items.Add(item);
            return true;
        }

        public bool RemoveItemById(int id)
        {
            int index = FindIndexById(id);

            if (index == -1)
            {
                return false;
            }

            Items.RemoveAt(index);
            return true;
        }

        public bool UseItemById(int id, Player player)
        {
            Item item = GetItemById(id);

            if (item == null)
            {
                return false;
            }

            item.Use(player);
            Items.Remove(item);
            return true;
        }

        public Item GetItemById(int id)
        {
            for (int i = 0; i < Items.Count; i = i + 1)
            {
                if (Items[i].Id == id)
                {
                    return Items[i];
                }
            }

            return null;
        }

        private int FindIndexById(int id)
        {
            for (int i = 0; i < Items.Count; i = i + 1)
            {
                if (Items[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
