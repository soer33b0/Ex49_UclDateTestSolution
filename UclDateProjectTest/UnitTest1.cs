using System;
using DateClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UclDateProjectTest
{
    [TestClass]
    public class UnitTest1
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
            Assert.AreEqual(dato.GetMonth(), 4);
        }

        [TestMethod]
        public void Test_GetDay()
        {
            Assert.AreEqual(dato.GetDay(), 23);
        }

        [TestMethod]
        public void Test_SetYear()
        {
            dato.SetYear(2000);
            Assert.AreEqual(dato.GetYear(), 2000);
            Assert.AreEqual(dato.GetMonth(), 4);
            Assert.AreEqual(dato.GetDay(), 23);
        }

        [TestMethod]
        public void Test_SetMonth()
        {
            dato.SetMonth(8);
            Assert.AreEqual(dato.GetYear(), 1990);
            Assert.AreEqual(dato.GetMonth(), 8);
            Assert.AreEqual(dato.GetDay(), 23);
        }

        [TestMethod]
        public void Test_SetDay()
        {
            dato.SetDay(13);
            Assert.AreEqual(dato.GetYear(), 1990);
            Assert.AreEqual(dato.GetMonth(), 4);
            Assert.AreEqual(dato.GetDay(), 13);
        }

        [TestMethod]
        public void Test_GetDateStringYMD()
        {
            Assert.AreEqual(dato.GetDatoStringYMD(), "1990-4-23");
        }

        [TestMethod]
        public void Test_GetDatoStringDMY()
        {
            Assert.AreEqual(dato.GetDatoStringDMY(), "23/4/1990");
        }

        [TestMethod]
        public void Test_GetQuater()
        {
            Assert.AreEqual(dato.GetQuater(), 2);
        }

        [TestMethod]
        public void Test_GetMonthTxt()
        {
            Assert.AreEqual(dato.GetMonthTxt(), "April");
        }

        [TestMethod]
        public void Test_GetQuaterTxt()
        {
            Assert.AreEqual(dato.GetQuaterTxt(), "2. kvartal");
        }        
        
        [TestMethod]
        public void Test_MoveToNextDate()
        {
            dato.MoveToNextDate();
            Assert.AreEqual(dato.GetDay(), 24);
        }

        [TestMethod]
        public void Test_MoveToPrevDate()
        {
            dato.MoveToPrevDate();
            Assert.AreEqual(dato.GetDay(), 22);
        }

        [TestMethod]
        public void Test_MoveDays()
        {
            dato.MoveDays(20);
            Assert.AreEqual(dato.GetDay(), 13);
        }

        [TestMethod]
        public void Test_GetDayNumber()
        {

        }
    }
}
