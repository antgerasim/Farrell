﻿using Farrell.Chapter4;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarrellUnitTests
{
    /// <summary>
    ///     WoodType_charge test. Includes basecharge +200, NO
    ///     surfacecharge, oak +125, 2 drawers + 60.
    ///     Final cost is 375.
    /// </summary>
    [TestClass()]
    public class Exercise7ATestCase4
    {
        private Exercise7A _systemUnderTest;
        private TestContext _testContextInstance;
        /// <summary>
        ///     Gets or sets the test context which provides
        ///     information about and functionality for the current
        ///     test run.
        /// </summary>
        public TestContext TestContext
        {
            get { return _testContextInstance; }
            set { _testContextInstance = value; }
        }

        /// <summary>
        ///     A test for Exercise7A Constructor
        /// </summary>
        //[TestMethod()]
        public void Exercise7AConstructorTest()
        {
            /*          Exercise7A target = new Exercise7A();
            Assert.Inconclusive("TODO: Implement code to verify target");*/
        }

        /// <summary>
        ///     A test for DisplayCustomerBill
        /// </summary>
        //[TestMethod()]
        public void DisplayCustomerBillTest()
        {
            /*         Exercise7A target = new Exercise7A(); // TODO: Initialize to an appropriate value
            target.DisplayCustomerBill();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");*/
        }

        #region MethodTests

        [TestMethod()]
        public void PrivateMethodTestCalcDrawerTotalParamTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CalcDrawerTotalParam", 3);

            int expected = 90;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodTestCalcDrawerTotalTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CalcDrawerTotal");

            int expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodTestCheckWoodTypeTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CheckWoodType");

            int expected = 125;//oak

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodTestCalcSurfaceTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CalcSurface");

            int expected = 700;//calc surface

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodSurfaceBarrierTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("SurfaceBarrier", 700);

            int expected = 0;//if is lesss than 750 then no charge.else +50$

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodCalcCustomerBillTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CalcCustomerBill");

            int expected = 385;//final customer bill

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region FieldTests

        [TestMethod()]
        public void PrivateMemberTest_customerName()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (string) obj.GetField("_customerName");
            var expected = "Sambuka";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_deskLength()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (int) obj.GetField("_deskLength");
            const int expected = 70;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_deskWidth()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (int) obj.GetField("_deskWidth");
            const int expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_numberDrawes()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (int) obj.GetField("_numberDrawes");
            const int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_woodType()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (string) obj.GetField("_woodType");
            const string expected = "oak";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_orderId()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (int) obj.GetField("_orderId");
            const int expected = 123456;

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Additional test attributes

        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //   // Exercise7AFactory();
        //}

        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            //surfacebarriertestcase < 750 = 50$ less
            _systemUnderTest = new Exercise7A("Sambuka", 70, 10, 2, 123456, "oak");
        }

        //
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            _systemUnderTest = null;
        }

        private Exercise7A Exercise7AFactory(string customerName, int deskLength, int deskWidth,
            int numberDrawes, int orderId, string woodType)
        {
            return new Exercise7A(customerName, deskLength, deskWidth, numberDrawes, orderId,
                woodType);
        }

        //public Exercise7A SystemUnderTest
        //{
        //    get
        //    {
        //        if (_systemUnderTest == null)
        //        {
        //            _systemUnderTest = new Exercise7A();
        //        }

        //        return _systemUnderTest;
        //    }
        //}

        #endregion
    }
}