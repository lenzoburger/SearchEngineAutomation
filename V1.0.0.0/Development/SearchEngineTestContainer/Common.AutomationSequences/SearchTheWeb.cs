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
        public object AutomationSequnce()
        {
            var sEngine = new SearchEngine("https://www.yahoo.com");


            try
            {


                var actual = false;
                sEngine.Search("Udemy");

                Assert.AreEqual(1, sEngine.validateSearchResults("https://www.udemy.com"));

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
