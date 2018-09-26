using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator.ClassLibrary;

namespace UnitTestProject2
{
    [TestClass]
    public class ClassInitializeClassCleanup
    {
        public static Rectangle rectangle;

        [ClassInitialize]
        public static void SetUp(TestContext testcontext)
        {
            rectangle = new Rectangle();
            rectangle.Width = 3;
            rectangle.Length = 4;
        }

        

        [ClassCleanup]
        public static void Cleanup()
        {
            rectangle = null;
        }

        [TestMethod]
        public void PerimeterTest()
        {
            

            double expected = 14;

            double actual = rectangle.Perimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaTest()
        {
            double expected = 12;

            double actual = rectangle.Area();

            Assert.AreEqual(expected, actual);

            rectangle.Width = 2;

        }
    }
}
