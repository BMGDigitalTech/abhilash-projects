using BasicUnitTesting.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicUnitTesting.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BasicUnitTestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculate c = new Calculate();
            double actualresult = c.Add(10, 20);
            double expectedresult = 30;
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            HomeController home = new HomeController();

            var vr = home.Index();


        }
    }
}
