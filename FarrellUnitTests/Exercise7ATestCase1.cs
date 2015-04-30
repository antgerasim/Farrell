using Farrell.Chapter4;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarrellUnitTests
{
    /// <summary>
    ///     Base case test. Includes basecharge +200, surfacecharge
    ///     +50, mahoganywood +150, 4 drawers + 120.
    ///     Final cost is 520.
    /// </summary>
    [TestClass()] //
    public class Exercise7ATestCase1
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

            int expected = 120;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodTestCheckWoodTypeTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CheckWoodType");

            int expected = 150;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodTestCalcSurfaceTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CalcSurface");

            int expected = 825;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodSurfaceBarrierTest()
        {
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("SurfaceBarrier", 825);

            int expected = 50;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMethodCalcCustomerBillTest()
        {
            //_systemUnderTest = new Exercise7A("Inga", 75, 11, 4, 123456, "mahogany");
            PrivateObject obj = new PrivateObject(_systemUnderTest);
            int actual = (int) obj.Invoke("CalcCustomerBill");

            int expected = 520;

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region FieldTests

        [TestMethod()]
        public void PrivateMemberTest_customerName()
        {
            //var systemUnderTest = Exercise7AFactory("Inga", 75, 11, 4, 123456, "mahogany");
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (string) obj.GetField("_customerName");
            var expected = "Inga";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_deskLength()
        {
            //var systemUnderTest = Exercise7AFactory("Inga", 75, 11, 4, 123456, "mahogany");
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (int) obj.GetField("_deskLength");
            const int expected = 75;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_deskWidth()
        {
            //var systemUnderTest = Exercise7AFactory("Inga", 75, 11, 4, 123456, "mahogany");
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (int) obj.GetField("_deskWidth");
            const int expected = 11;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_numberDrawes()
        {
            //var systemUnderTest = Exercise7AFactory("Inga", 75, 11, 4, 123456, "mahogany");
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (int) obj.GetField("_numberDrawes");
            const int expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_woodType()
        {
            //var systemUnderTest = Exercise7AFactory("Inga", 75, 11, 4, 123456, "mahogany");
            PrivateObject obj = new PrivateObject(_systemUnderTest);

            var actual = (string) obj.GetField("_woodType");
            const string expected = "mahogany";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrivateMemberTest_orderId()
        {
            //var systemUnderTest = Exercise7AFactory("Inga", 75, 11, 4, 123456, "mahogany");
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
            _systemUnderTest = new Exercise7A("Inga", 75, 11, 4, 123456, "mahogany");
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