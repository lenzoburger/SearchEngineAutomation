using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchEngineTestContainer.Common.AutomationSequences;

namespace SearchEngineTestContainer.Common.AutomationRunners
{
    /// <summary>
    /// Summary description for MainTestsRunner
    /// </summary> 
    [TestClass]
   [DeploymentItem("IEDriverServer.exe")]
   [DeploymentItem("chromedriver.exe")]
   [DeploymentItem("geckodriver.exe")]
   [DeploymentItem("MicrosoftWebDriver.exe")]
   [DeploymentItem("Resources.DataSources\\CsvDataSource.csv")]
    public class MainTestsRunner
    {
        public MainTestsRunner()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "CsvDataSource.csv", "CsvDataSource#csv", DataAccessMethod.Sequential)]
        public void SearchTheWeb()
        {
            var testCase = new SearchTheWeb();

            testCase.driverParams = TestContext.DataRow["driverParams"].ToString();

            testCase.sEngineUrl = TestContext.DataRow["sEngineUrl"].ToString();

            testCase.resultPattern = TestContext.DataRow["resultPattern"].ToString();

            testCase.searchKeyword = "Udemy";

            var actual = testCase.AutomationSequnce();

            Assert.AreEqual(true, actual);
        }



        #region Additional test attributes    

        
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

    }
}
