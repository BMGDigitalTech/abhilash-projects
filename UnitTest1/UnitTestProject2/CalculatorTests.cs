
using System;


namespace Calculator.ClassLibrary
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

  

    [TestClass]
    public class CalculatorTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Owner("Abhilash")]
        [Priority(1)]
        public void Divide_PositiveNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int expected = 5;
            int a = 20;
            int b = 4;

            // Act
            int actual = Calculator.divide(a, b);
            System.Threading.Thread.Sleep(1000);

            //Assert
            Assert.AreEqual(expected, actual);

            TestContext.WriteLine(TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine(TestContext.TestName);
            
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Ron")]
        [Priority(1)]
        public void Divide_PositiveNumeratorAndNegativeDenominator_ReturnsNegativeQuotient()
        {
            // Arrange
            int expected = -5;
            int a = 20;
            int b = -4;

            // Act
            int actual = Calculator.divide(a, b);
            System.Threading.Thread.Sleep(400);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Owner("Abhilash")]
        [Priority(1)]
        public void Divide_NegativeNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int expected = 5;
            int a = -20;
            int b = -4;

            // Act
            int actual = Calculator.divide(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_By_Zero_Exception()
        {
            // Arrange
            int a = 20;
            int b = 0;

            // Act
            try
            {
                Calculator.divide(a, b);
            }
            catch(DivideByZeroException ex)
            {
                Assert.AreEqual("Denominator cannot be Zero", ex.Message);
                throw;
            }
        }

        [TestMethod]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            // Arrange
            int a = 10;
            int b = 20;

            // Act
            int actual = Calculator.Add(a, b);

            int expected = 30;

            // Assert
            Assert.AreEqual(actual, expected);

        }
    }
}
