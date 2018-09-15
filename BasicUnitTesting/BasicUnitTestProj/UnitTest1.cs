using BasicUnitTesting.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicUnitTesting.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
           

            HomeController home = new HomeController(null);

            var vr = home.Index() as ViewResult;

            string expectedresult = "Index";

            Assert.AreEqual(expectedresult, vr.ViewName);

        }


        [TestMethod]
        public void TestMethod3()
        {
            HomeController home = new HomeController(null);

            var vr = home.Square(5) as ViewResult;

            int expectedresult = 25;

            Assert.AreEqual(expectedresult, vr.ViewData["sq"]);

        }

        [TestMethod]
        public void GetEmployeeTest()
        {
            HomeController home = new HomeController(new CompanyDbContext());

            var vr = home.GetEmployee() as ViewResult;

            List<Employee> expectedemps = new List<Employee>()
            {
                new Employee() {EmpID=101,EmpName="Abhilash",Salary=50000},
                new Employee() {EmpID=102,EmpName="Abhishek",Salary=60000},
                new Employee() {EmpID=103,EmpName="Nagraj",Salary=30000},
                new Employee() {EmpID=104,EmpName="Sunil",Salary=50000},
                new Employee() {EmpID=105,EmpName="Vinay",Salary=40000}
            };

            Assert.IsTrue(expectedemps.SequenceEqual(vr.Model as List<Employee>));
        }
    }
}
