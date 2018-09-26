using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class AssemblyInitializeAssemblyCleanup
    {
        public static TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            context.WriteLine("AssemblyInitialize");
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            context.WriteLine("ClassInitialize");
        }

        [TestInitialize]
        public void TestInit()
        {
            TestContext.WriteLine("TestInitialize");
        }

        [TestCleanup]
        public void TestCleanUpMethod()
        {
            TestContext.WriteLine("TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanupMethod()
        {
            Console.WriteLine("ClassCleanup");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanUpMethod()
        {

            Console.WriteLine("AssemblyCleanUp");
        }

        [TestMethod]
        public void MyTestMethod()
        {
            TestContext.WriteLine("TestMethod");
        }
    }
}
