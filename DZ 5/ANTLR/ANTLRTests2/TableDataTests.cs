using Microsoft.VisualStudio.TestTools.UnitTesting;
using ANTLR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ANTLR.Tests
{
    [TestClass()]
    public class TableDataTests
    {
        [TestMethod()]
        public void Power()
        {
            string numberr = "5";
            string power = "2";
            double expected = 25;

            //act
            
            double actual = Calculator.Evaluate(numberr + "^" + power);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxMin()
        {
            string x = "5";
            string y = "6";
            double expected = 6;

            //act

            double actual = Calculator.Evaluate("max(" + x + " , " + y + ")");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Divide()
        {
            string x = "5";
            string y = "0";
            double expected = double.PositiveInfinity;

            //act

            double actual = Calculator.Evaluate(x + "/" + y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}