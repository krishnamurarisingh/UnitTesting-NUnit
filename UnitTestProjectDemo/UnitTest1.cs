using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnitDemo;
using NUnitDemo.Models;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProjectDemo
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    int i = 10, j = 0, x;
        //    x = i / j;
        //}

        // TestMethod Case#1: Sales Amount is Greater or Equal than 1000 : Verification  
        //__________Test for Expected Results__________  
        // TestMethod Case#1: Sales Amount is Greater or Equal than 1000 : Verification  
        [TestMethod]
        public void OneThousand_G_E()
        {
            UtilityLib obj = new UtilityLib();
            Assert.AreEqual(950, obj.calculateDiscount(1000));
        }
        // TestMethod Case#2: Sales Amount is Greater or Equal than 2000 : Verification  
        [TestMethod]
        public void TwoThousand_G_E()
        {
            UtilityLib obj = new UtilityLib();
            Assert.AreEqual(1800, obj.calculateDiscount(2000));
        }
        // TestMethod Case#3: Sales Amount is Greater or Equal than 5000 : Verification  
        [TestMethod]
        public void FiveThousand_G_E()
        {
            UtilityLib obj = new UtilityLib();
            Assert.AreEqual(2500, obj.calculateDiscount(5000));
        }
        // TestMethod Case#4: Sales Amount is 0 : Verification  
        [TestMethod]
        public void ZeroAmount()
        {
            UtilityLib obj = new UtilityLib();
            try
            {
                obj.calculateDiscount(0);
            }
            catch (Exception e) { }
        }
        // TestMethod Case#5: Sales Amount is below 1000 : Verification  
        [TestMethod]
        public void OneThousand_Below()
        {
            UtilityLib obj = new UtilityLib();
            Assert.AreEqual(999, obj.calculateDiscount(999));
        }
        //__________Test for Actual Results__________  
        // TestMethod Case#6: Sales Amount is not producing expected Result : Verification  
        [TestMethod]
        public void OneThousand()
        {
            UtilityLib obj = new UtilityLib();
            Assert.AreNotEqual(930, obj.calculateDiscount(1000));
        }
        // TestMethod Case#7: Sales Amount is not producing expected Result : Verification  
        [TestMethod]
        public void TwoThousand()
        {
            UtilityLib obj = new UtilityLib();
            Assert.AreNotEqual(1900, obj.calculateDiscount(2000));
        } 
    }
}
