using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [DataRow(3, 3, 6)]
        [DataRow(5, 6, 11)]
        [DataRow(6, 6, 11)]
        [DataTestMethod]
        public void AddTest(int num1, int num2, int result)
        {
            //Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Add(num1, num2) == result);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(calculator.Multiply(3, 2) == 6);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsTrue(calculator.Divide(8, 2) == 4);
        }
    }
}