using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Problem
{
    public class Item
    {
        public int id, weight, value;

        public Item(int id, int weight = 0, int value = 0)
        {
            this.id = id;
            this.weight = weight;
            this.value = value;
        }

        public static int CompareItems(Item item1, Item item2)
        {
            if (item1.value / item1.weight > item2.value / item2.weight)
                return -1;
            else if (item1.value / item1.weight == item2.value / item2.weight)
                return 0;
            else
                return 1;
        }


        public override string ToString()
        {
            string str = id + "\tW: " + weight + "\tV: " + value;
            return str;
        }
    }
}
