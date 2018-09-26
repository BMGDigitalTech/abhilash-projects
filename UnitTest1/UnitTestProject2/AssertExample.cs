using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override bool Equals(object obj)
        //{
        //    Customer otherCustomerObject = obj as Customer;
        //    if(otherCustomerObject == null)
        //    {
        //        return false;
        //    }
        //    return this.FirstName == otherCustomerObject.FirstName &&
        //        this.LastName == otherCustomerObject.LastName;
        //}

        //public override int GetHashCode()
        //{
        //    return this.FirstName.GetHashCode();
        //}
    }

    public class CustomerComparer : IComparer
    {
        public int Compare(object x, object y)
        {
                Customer c1 = x as Customer;
                Customer c2 = y as Customer;
                
            if(c1 == null || c2 == null)
            {
                return -1;
            }

            return (c1.FirstName.CompareTo(c2.FirstName)) + (c1.LastName.CompareTo(c2.LastName)); ;
        }
    }

    public class GoldCustomer : Customer
    {

    }

    public class Employee
    {
        public int ID { get; set; }
    }

    [TestClass]
    public class AssertExample
    {
        [TestMethod]
        public void AreEqual()
        {
            double expected = 26;
            double actual = Math.Pow(5, 2);

            Assert.AreEqual(expected, actual, "{0} Power {1} is 25", 5, 2);
        }

        [TestMethod]
        public void AreSame()
        {
            Customer c1 = new Customer() { FirstName = "David" };
            Customer c2 = new Customer() { FirstName = "David" };

            //c2 = c1;

            //Assert.AreSame(c1, c2);
            Assert.AreNotSame(c1, c2);
        }

        [TestMethod]
        public void Fail()
        {
            // Fails the assertion without checking any condition
            // Assert.Fail("Simply fail the tests");

            // Indicates that the assertion cannot be verified
            Assert.Inconclusive();

        }

        [TestMethod]
        public void isTrue()
        {
            int num1 = 4;
            int num2 = 4;

            Assert.IsTrue(num1 == num2);

            //Assert.IsFalse(num1 != num2);
        }

        [TestMethod]
        public void IsNull()
        {
            Assert.IsNull(null);

           // Assert.IsNotNull(new Customer());
        }

        [TestMethod]
        public void IsInstanceOfType()
        {
            GoldCustomer c1 = new GoldCustomer() { FirstName = "Abhilash" };
            Assert.IsInstanceOfType(c1, typeof(GoldCustomer));
        }

        [TestMethod]
        public void TestObjectPropertiesEqual()
        {
            Customer c1 = new Customer()
            {
                FirstName = "Abhilash",
                LastName = "Narayan"
            };

            Customer c2 = new Customer()
            {
                FirstName = "Abhilash",
                LastName = "Narayan"
            };

            Assert.AreEqual(c1.FirstName, c2.FirstName);
            Assert.AreEqual(c1.LastName, c2.LastName);
        }

        private static bool AreObjectPropertiesEqual(Customer expected, Customer actual)
        {
            return expected.FirstName == actual.FirstName &&
                   expected.LastName == actual.LastName;
        }

        [TestMethod]
        public void TestObjectPropertiesEqual2()
        {
            Customer c1 = new Customer()
            {
                FirstName = "Abhilash",
                LastName = "Narayan"
            };

            Customer c2 = new Customer()
            {
                FirstName = "Abhilash",
                LastName = "Narayan"
            };

            Assert.IsTrue(AreObjectPropertiesEqual(c1, c2));
        }

        [TestMethod]
        public void StringCollectionTest()
        {
            List<String> collection1 = new List<string>() { "John", "Abhilash", "Dave" };
            List<String> collection2 = new List<string>() { "John", "Abhilash", "Dave" };
            CollectionAssert.AreEqual(collection1, collection2);
        }

        [TestMethod]
        public void IntegerCollectionTest()
        {
            List<int> collection1 = new List<int>() { 10, 20, 30 };
            List<int> collection2 = new List<int>() { 10, 20, 30 };
            CollectionAssert.AreEqual(collection1, collection2);
        }

        [TestMethod]
        public void ComplexObjectsCollectionTest()
        {
            List<Customer> collection1 = new List<Customer>()
            {
                new Customer() { FirstName = "Abhilash", LastName="Narayan"},
                new Customer() {FirstName="Abhishek", LastName="Kulkarni"},
                new Customer() {FirstName="Arjun", LastName="Venkantesh"}
            };

            List<Customer> collection2 = new List<Customer>()
            {
                new Customer() { FirstName = "Abhilash", LastName="Narayan"},
                new Customer() {FirstName="Abhishek", LastName="Kulkarni"},
                new Customer() {FirstName="Arjun", LastName="Venkantesh"}
            };

            // CollectionAssert.AreEqual(collection1, collection2);
            CollectionAssert.AreEqual(collection1, collection2, new CustomerComparer());
            // CollectionAssert.AreEqual(collection1.Select(x => x.FirstName + x.LastName).ToList(), collection2.Select(x => x.FirstName + x.LastName).ToList());
        }


        [TestMethod]
        public void ComplexObjectsCollectionTest_AreEqvivalent()
        {
            List<Customer> collection1 = new List<Customer>()
            {
                new Customer() { FirstName = "Abhilash", LastName="Narayan"},
                new Customer() {FirstName="Abhishek", LastName="Kulkarni"},
                new Customer() {FirstName="Arjun", LastName="Venkantesh"}
            };

            List<Customer> collection2 = new List<Customer>()
            {
                new Customer() { FirstName = "Abhilash", LastName="Narayan"},
                new Customer() {FirstName="Abhishek", LastName="Kulkarni"},
                new Customer() {FirstName="Arjun", LastName="Venkantesh"}
            };

            CollectionAssert.AreEquivalent(collection1, collection2);
            
        }

        [TestMethod]
        public void ComplexObjectsCollectionTest_Contains()
        {
            List<Customer> collection1 = new List<Customer>() {
                new Customer() { FirstName = "Abhilash", LastName = "N" },
                new Customer() {FirstName="Anup", LastName="K"},
                new Customer() {FirstName="Anil", LastName="K"}
        };

            CollectionAssert.Contains(collection1, new Customer() { FirstName = "Abhilash", LastName="N" });

        }

        [TestMethod]
        public void ComplexObjectsCollectionTest_IsSubsetOf()
        {
            List<Customer> superset = new List<Customer>() {
                new Customer() { FirstName = "Abhilash", LastName = "N" },
                new Customer() {FirstName="Anup", LastName="K"},
                new Customer() {FirstName="Anil", LastName="K"}
        };

            List<Customer> subset = new List<Customer>() {
              
                new Customer() {FirstName="Anup", LastName="K"},
                new Customer() {FirstName="Anil", LastName="K"}
        };

            CollectionAssert.IsSubsetOf(subset, superset); 

        }

    }
}
