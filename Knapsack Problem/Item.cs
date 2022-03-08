using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Problem
{
    internal class Item
    {
        public int weight, value;

        public Item(int weight = 0, int value = 0)
        {
            this.weight = weight;
            this.value = value;
        }

        public override string ToString()
        {
            String str = "W: " + this.weight + " V: " + this.value;
            return str;
        }
    }
}
