using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorAPI;

namespace CalculatorAPI.Tests
{
    [TestClass]
    public class CalculatorAPIAddTest
    {
        [TestMethod]
        public void Add_TwoPositive_Values()
        {

            //Arrange
            double val1 = 1;
            double val2 = 2;
            double exp = 3;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Add);

            //Assert
            Assert.AreEqual(exp, result);

        }

        [TestMethod]
        public void Add_OnePositive_And_OneNegative_Values()
        {

            //Arrange
            double val1 = 1;
            double val2 = -2;
            double exp = -1;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Add);

            //Assert
            Assert.AreEqual(exp, result);

        }

        [TestMethod]
        public void Add_OneNegative_And_OnePositive_Values()
        {

            //Arrange
            double val1 = -2;
            double val2 = 3;
            double exp = 1;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Add);

            //Assert
            Assert.AreEqual(exp, result);

        }


    }
}
