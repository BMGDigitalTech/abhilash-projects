
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivide()
        {   
            //Arrange
            int expected = 5;
            int a = 20;
            int b = 4;

            //Act
            int actual = Calculator.Library.Calculator.Divide(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
