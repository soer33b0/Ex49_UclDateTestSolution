using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateClassLibrary;

namespace DateUnitTestProject
{
    [TestClass]
    public class UnitTestDate
    {
        UclDate dato = new UclDate(1990, 4, 23);

        [TestMethod]
        public void TestMethod_DateConstructor()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.IsNotNull(aDate, "UclDate Constructor is not working");
        }

        [TestMethod]
        public void Test_GetYear()
        { 
            Assert.AreEqual(dato.GetYear(), 1990);
        }

        [TestMethod]
        public void Test_GetMonth()
        {
            
        }
    }
}
