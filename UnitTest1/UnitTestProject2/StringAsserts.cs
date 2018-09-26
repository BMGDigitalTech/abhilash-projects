using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class StringAsserts
    {
        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Unit Testing Tutorial", "Unit");
        }

        [TestMethod]
        public void EndsWithTest()
        {
            StringAssert.EndsWith("Unit Testing Tutorial", "Tutorial");
        }

        [TestMethod]
        public void ContainsTest()
        {
            StringAssert.Contains("Unit testing tutorial", "testing");
        }

        [TestMethod]
        public void MatchesTest()
        {
            Regex regex = new Regex(@"[0-9]");
            StringAssert.Matches("123456", regex);
        }

        
    }
}
