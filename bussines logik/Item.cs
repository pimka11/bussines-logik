using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussines_logik
{
    public class Item
    {
        
        public int Id;
        public string Name;
        public int Price;

        public Item(int id, string name, int price)
        {
            Name = name;
            Price = price;
            Id = id;
        }

        public virtual void Use(Player player)
        {
            Console.WriteLine("юзнули шмотку" + Name);
        }
    }
}
