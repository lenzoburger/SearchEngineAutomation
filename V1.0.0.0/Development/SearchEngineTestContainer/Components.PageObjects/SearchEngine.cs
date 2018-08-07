using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverWrapper;

namespace SearchEngineTestContainer.Components.PageObjects
{
    class SearchEngine : SeleniumHandler
    {
        public SearchEngine() { }

        public SearchEngine(string url) { }

        public void Search(string keyword)
        {
            throw new NotImplementedException();
        }              

        public int validateSearchResult(string pattern)
        {
            throw new NotImplementedException();
        }
    }
}
