using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Problem
{
    public class Generator
    {
        List<Item> items;

        public Generator(int n, int seed = 1)
        {
            items = new List<Item>();   
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                Item new_item = new Item(i+1, random.Next(1, 10), random.Next(1, 20));
                items.Add(new_item);
            }
        }

        public List<Item> getItems()
        {
            return items;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach(var item in items)
            {
                str += item.ToString() + Environment.NewLine;
            }
            return str;
        }
    }
}
