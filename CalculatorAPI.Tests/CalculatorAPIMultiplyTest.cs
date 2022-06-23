using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorAPI;

namespace CalculatorAPI.Tests
{
    [TestClass]
    public class CalculatorAPIMultiplyTest
    {
        [TestMethod]
        public void Multiply_TwoPositive_Values()
        {

            //Arrange
            double val1 = 1;
            double val2 = 2;
            double exp = 2;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Multiply);

            //Assert
            Assert.AreEqual(exp, result);

        }

        [TestMethod]
        public void Multiply_OnePositive_And_OneNegative_Values()
        {

            //Arrange
            double val1 = 1;
            double val2 = -2;
            double exp = -2;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Multiply);

            //Assert
            Assert.AreEqual(exp, result);

        }

        [TestMethod]
        public void Multiply_OneNegative_And_OnePositive_Values()
        {

            //Arrange
            double val1 = -2;
            double val2 = 3;
            double exp = -6;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Multiply);

            //Assert
            Assert.AreEqual(exp, result);

        }
    }
}
