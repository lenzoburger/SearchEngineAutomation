using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineTestContainer.Resources.ObjectRepo
{
    public static class ObjectsRepo
    {
        public static class SearchEngines
        {
            public static By searchTextBox = By.CssSelector("#lst-ib, #sb_form_q, #uh-search-box");
            public static By AutoCompleteItem = By.CssSelector(".sbsb_b li, #sa_ul li, [role=listbox] li");
            public static By resultEntities = By.CssSelector(".g, .b_algo, .mb-15 li");
            public static By privacyPopUpClose = By.ClassName("gb_wa");
        }
    }
}
