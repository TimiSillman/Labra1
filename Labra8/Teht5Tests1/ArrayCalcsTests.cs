using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teht5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        double[] array = { };
        [TestMethod()]
        public void sumTest()
        {
            ArrayCalcs asd = new ArrayCalcs();
            int expected = 0;
            double actual = asd.sum(array);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void aveTest()
        {
            ArrayCalcs asd = new ArrayCalcs();
            int expected = 0;
            double actual = asd.ave(array);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void maxTest()
        {
            ArrayCalcs asd = new ArrayCalcs();
            int expected = 0;
            double actual = asd.max(array);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void minTest()
        {
            ArrayCalcs asd = new ArrayCalcs();
            int expected = 0;
            double actual = asd.min(array);

            Assert.AreEqual(expected, actual);
        }
    }
}