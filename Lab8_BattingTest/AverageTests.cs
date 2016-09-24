using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_8;

namespace Lab8_BattingTest
{
    [TestClass]
    public class AverageTests
    {
        [TestMethod]
        public void TestBattingPercentageIs0WhenNoRuns()
        {
            int[] battingSheet = new int[5];

            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;

            double battingAverage = Program.calculateBattingAverage(battingSheet);
            Assert.AreEqual(0, battingAverage);
        }

        [TestMethod]
        public void testBattingPercentageIs60()
        {
            int[] battingSheet = new int[5];

            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;

            double battingAverage = Program.calculateBattingAverage(battingSheet);
            Assert.AreEqual(0.6, battingAverage);
        }
       
        [TestMethod]
        public void sluggingPercentage()
        {
            int[] battingSheet = new int[5];

            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;


            double sluggingAverage = Program.calculateSluggingAverage(battingSheet);
            Assert.AreEqual(1.4, sluggingAverage);
            
        }
        
    }
}
