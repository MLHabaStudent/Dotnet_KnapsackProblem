using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Problem
{
    public class Solver
    {
        List<Item> knapsack;
        int totalWeight = 0,
            totalValue = 0;
        public Solver()
        {
            knapsack = new List<Item>();
        }

        public void Solve(int cap, List<Item> items)
        {
            knapsack.Clear();
            totalWeight = 0;
            totalValue = 0;

            foreach(Item item in items)
            {
                if(totalWeight + item.weight <= cap)
                {
                    knapsack.Add(item);
                    totalWeight += item.weight;
                    totalValue += item.value;
                }
            }
        }

        public void SolveSort(int cap, List<Item> items)
        {
            knapsack.Clear();
            totalWeight = 0;
            totalValue = 0;

            List<Item> sorted = items;
            sorted.Sort(Item.CompareItems);

            foreach (Item item in sorted)
            {
                if (totalWeight + item.weight <= cap)
                {
                    knapsack.Add(item);
                    totalWeight += item.weight;
                    totalValue += item.value;
                }
            }
        }

        public List<Item> getKnapsack()
        {
            return knapsack;
        }

        public int getWeight()
        {
            return totalWeight;
        }

        public int getValue()
        {
            return totalValue;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (Item item in knapsack)
            {
                str += item.ToString() + Environment.NewLine;
            }
            return str;
        }
    }
}
