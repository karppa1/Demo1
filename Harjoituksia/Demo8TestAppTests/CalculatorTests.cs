using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo8TestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8TestApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 12;

            // act
            int actual = calc.Add(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);

            //Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 35;

            // act
            int actual = calc.Multiply(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);

            //Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calc = new Calculator();
            int number1 = 10;
            int number2 = 2;
            int expected = 5;

            int actual = calc.Divide(number1, number2);

            Assert.AreEqual(expected, actual);

            //Assert.Fail();
        }
    }
}