using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
            var handler = new SeleniumHandler();
            try
            {
                var actual = false;

                handler.WebDriverParams = "{\"Driver\":\"Firefox\"}";
                handler.GoToUrl("https://www.google.com/");

                handler.WebDriver.BannersListner(By.ClassName("gb_wa"));

                handler.GetDisplayedElement(By.Id("lst-ib")).SendKeys("udemy");

                handler.WaitForDisplayedElement(By.CssSelector("#sbtc > div.gstl_0.sbdd_a > div:nth-child(2) > div.sbdd_b > div > ul > li:nth-child(1)")).Click();



                handler.WaitForDisplayedElement(By.ClassName("g"));

                var results = handler.GetDisplayedElements(By.ClassName("g"));



                Assert.IsTrue(results[0].Text.Contains("www.udemy.com"),"The first is not for udemy.com");

                actual = true;

                Thread.Sleep(3000);

                return actual;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally { handler.WebDriver.Dispose(); }
        }
    }
}
