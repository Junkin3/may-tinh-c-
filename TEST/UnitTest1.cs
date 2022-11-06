using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator;


namespace TEST
{

    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        private Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"),2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            int a, b, expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            cal = new Calculation(a, b);
            actual = cal.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}


