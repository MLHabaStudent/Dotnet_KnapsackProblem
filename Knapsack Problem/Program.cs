using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cap, seed;
            Console.Write("Wprowadź ilość przedmiotów: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Wprowadź pojemność plecaka: ");
            cap = int.Parse(Console.ReadLine());
            Console.Write("Wprowadź seed: ");
            seed = int.Parse(Console.ReadLine());

            Generator generator = new Generator(n, seed);
            Solver solver = new Solver();
            solver.Solve(cap, generator.getItems());

            Console.WriteLine(generator);
            Console.WriteLine(solver);            
            Console.WriteLine("Weight: " + solver.getWeight() + " Value: " + solver.getValue());
            Console.ReadLine();
        }
    }
}
