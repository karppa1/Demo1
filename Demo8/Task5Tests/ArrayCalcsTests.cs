using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //double[] taulukko = { };
            double[] taulukko = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 25.6;

            double actual = ArrayCalcs.Sum(taulukko);
            
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void AvgTest()
        {
            //double[] taulukko = { };
            double[] taulukko = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 3.66;

            double actual = Math.Round(ArrayCalcs.Avg(taulukko),2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            //double[] taulukko = { };
            double[] taulukko = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = -4.5;

            double actual = ArrayCalcs.Min(taulukko);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            //double[] taulukko = { };
            double[] taulukko = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 12;

            double actual = ArrayCalcs.Max(taulukko);

            Assert.AreEqual(expected, actual);
        }
    }
}