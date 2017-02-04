using Microsoft.VisualStudio.TestTools.UnitTesting;
using Esimerkki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimerkki.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //aaa periaate
            //arrange
            //act
            //assert
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 9;
            int actual = calc.Add(a, b);

            Assert.AreEqual(expected, actual );

            a = 0;
             b = 1;
            expected = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 20;
            int actual = calc.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DivideTest()
        {
            Calculator calc = new Calculator();
            int a = 10;
            int b = 5;
            int expected = 2;
            int actual = calc.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calc = new Calculator();
            int a = 5;
            int b = 4;
            int expected = 1;
            int actual = calc.Substract(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}