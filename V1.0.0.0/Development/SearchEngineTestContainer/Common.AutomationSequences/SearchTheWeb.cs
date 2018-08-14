using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SearchEngineTestContainer.Components.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverWrapper;
using WebDriverWrapper.Extensions;

namespace SearchEngineTestContainer.Common.AutomationSequences
{
    class SearchTheWeb
    {
        public string sEngineUrl { get; set; }

        public string resultPattern { get; set; }

        public string searchKeyword { get; set; }

        public string driverParams { get; set; }

        public object AutomationSequnce()
        {

            var sEngine = new SearchEngine(sEngineUrl, driverParams);


            try
            {


                var actual = false;
                sEngine.Search(searchKeyword);

                Assert.AreEqual(1, sEngine.validateSearchResults(resultPattern));

                actual = true;            
                return actual;





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally { sEngine.WebDriver.Dispose(); }
        }
    }
}
