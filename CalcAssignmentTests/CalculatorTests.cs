using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAssignment.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var calc = new Calculator();

            double expected = 25;
            double result = calc.Add(10, 15);
            Assert.AreEqual(expected, result);

            expected = 12.5;
            result = calc.Add(10, 2.5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var calc = new Calculator();

            double expected = 10;
            double result = calc.Subtract(15, 5);
            Assert.AreEqual(expected, result);

            expected = 73.2;
            result = calc.Subtract(80.5, 7.3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var calc = new Calculator();

            double expected = 10;
            double result = calc.Multiply(5, 2);
            Assert.AreEqual(expected, result);

            expected = 4.8;
            result = calc.Multiply(2.4, 2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var calc = new Calculator();

            double expected = 5;
            double result = calc.Divide(10, 2);
            Assert.AreEqual(expected, result);

            expected = 7.5;
            result = calc.Divide(22.5, 3);
            Assert.AreEqual(expected, result);

            result = calc.Divide(5, 0);
            Assert.IsTrue(double.IsInfinity(result));
        }
    }
}