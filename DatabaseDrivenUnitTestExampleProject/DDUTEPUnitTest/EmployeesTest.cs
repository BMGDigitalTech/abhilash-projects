using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseDrivenUnitTestExampleProject.Models;
using System;

namespace DDUTEPUnitTest
{
    [TestClass]
    public class EmployeesTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance;  }
            set { testContextInstance = value; }
        }

        [TestMethod]
        [DataSource("System.Data.SqlClient", "data source=DESKTOP-ICCJEV3\\SQLEXPRESS;database=TestDb; integrated security=true","Employees",DataAccessMethod.Sequential)]
        public void DataDrivenEmployeesTest()
        {
            Employees emp = new Employees();
            emp.Name = TestContext.DataRow["Name"].ToString();

        }
    }
}
