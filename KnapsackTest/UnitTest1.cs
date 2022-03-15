using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Knapsack_Problem;

namespace KnapsackTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GeneratorTest()
        {
            for(int i = 0; i < 10; i++)
            {
                Generator generator = new Generator(i, 1);
                Assert.AreEqual(i, generator.getItems().Count);
            }
        }

        [TestMethod]
        public void MaxCapTest()
        {
            Generator generator = new Generator(10, 1);
            Solver solver = new Solver();
            solver.Solve(10000, generator.getItems());

            Assert.AreEqual(solver.getKnapsack().Count, generator.getItems().Count);
        }

        [TestMethod]
        public void MinCapTest()
        {
            Generator generator = new Generator(10, 1);
            Solver solver = new Solver();
            solver.Solve(0, generator.getItems());

            Assert.AreEqual(solver.getKnapsack().Count, 0);
        }

        [TestMethod]
        public void SeedTest_10()
        {
            Generator generator = new Generator(2, 10);
            Solver solver = new Solver();
            solver.Solve(50, generator.getItems());

            Assert.AreEqual(solver.getValue(), 29);
            Assert.AreEqual(solver.getWeight(), 16);
        }

        [TestMethod]
        public void SeedTest_20()
        {
            Generator generator = new Generator(5, 20);
            Solver solver = new Solver();
            solver.Solve(50, generator.getItems());

            Assert.AreEqual(solver.getValue(), 54);
            Assert.AreEqual(solver.getWeight(), 25);
        }
    }
}
