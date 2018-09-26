using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        [Timeout(2000)]
        public void TestMethod0()
        {
            System.Threading.Thread.Sleep(4000);
        }

        [TestMethod]
        [TestCategory("Demo"), TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Abhilash")]
        [Priority(2)]
        public void Method1()
        {

        }

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test Group", "Security")]
        [Owner("Ron")]
        [Priority(2)]
        public void Method2()
        {

        }

        [TestMethod]
        [Ignore]
        public void MyTestMethod3()
        {

        }
    }
}
