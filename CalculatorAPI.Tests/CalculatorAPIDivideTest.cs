using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorAPI.Tests
{
    [TestClass]
    public class CalculatorAPIDivideTest
    {
        [TestMethod]
        public void Divide_TwoPositive_Values()
        {

            //Arrange
            double val1 = 1;
            double val2 = 2;
            double exp = 0.5;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Divide);

            //Assert
            Assert.AreEqual(exp, result);

        }

        [TestMethod]
        public void Divide_OnePositive_And_OneNegative_Values()
        {

            //Arrange
            double val1 = 1;
            double val2 = -2;
            double exp = -0.5;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Divide);

            //Assert
            Assert.AreEqual(exp, result);

        }

        [TestMethod]
        public void Divide_OneNegative_And_OnePositive_Values()
        {

            //Arrange
            double val1 = 3;
            double val2 = -2;
            double exp = -1.5;

            double result = 0;
            //Act
            result = CalculatorAPI.Calculator.calculate(val1, val2, Helper.Divide);

            //Assert
            Assert.AreEqual(exp, result);

        }
    }
}
