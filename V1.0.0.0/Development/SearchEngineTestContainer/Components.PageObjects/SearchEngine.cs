using OpenQA.Selenium;
using SearchEngineTestContainer.Resources.ObjectRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebDriverWrapper;
using WebDriverWrapper.Extensions;

namespace SearchEngineTestContainer.Components.PageObjects
{
    class SearchEngine : SeleniumHandler
    {
        public SearchEngine() { }

        public SearchEngine(string url) {
            try
            {
                GoToUrl(url);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Search(string keyword)
        {
            try
            {
                //WebDriver.BannersListner(ObjectsRepo.SearchEngines.privacyPopUpClose);

                GetDisplayedElement(ObjectsRepo.SearchEngines.searchTextBox).SendKeys(keyword);
                WaitForDisplayedElement(ObjectsRepo.SearchEngines.AutoCompleteItem).Click();
                WaitForDisplayedElement(ObjectsRepo.SearchEngines.resultEntities);

            }
            catch (Exception)
            {

                throw;
            }
        }              

        public int validateSearchResults(string pattern)
        {
            try
            {
                var results = GetDisplayedElements(ObjectsRepo.SearchEngines.resultEntities);
                foreach (IWebElement result in results)
                {
                    if (Regex.IsMatch(result.Text, pattern))
                    {
                        return results.IndexOf(result)+1;
                    }
                }

                return -1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
