using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Problem
{
    internal class Item
    {
        public int id, weight, value;

        public Item(int id, int weight = 0, int value = 0)
        {
            this.id = id;
            this.weight = weight;
            this.value = value;
        }

        public override string ToString()
        {
            string str = id + "\tW: " + weight + "\tV: " + value;
            return str;
        }
    }
}
