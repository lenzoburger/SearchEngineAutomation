using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverWrapper;

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

                handler.GetDisplayedElement(By.Id("lst-ib")).SendKeys("udemy");

                handler.WaitForDisplayedElement(By.CssSelector("#sbtc > div.gstl_0.sbdd_a > div:nth-child(2) > div.sbdd_b > div > ul > li:nth-child(1)"));

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
