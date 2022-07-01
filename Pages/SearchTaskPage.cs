using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class SearchTaskPage : PageBase
    {
        By campopesquisar = By.XPath("//*[@id='nav-search']/form/span/input");
        By clickenter = By.XPath("//*[@id='nav-search']/form/span/input");
        By idtask = By.XPath("//tbody/tr/td[@class='bug-id']");
        By msgnotfound = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]");
        public void Searchtask(string task)
        {
            SendKeys(campopesquisar, task);
        }
         public void ClicandoEnter()
        {
            driver.FindElement(clickenter).SendKeys(Keys.Enter);
        }
        public string ValidSearch()
        {
            return GetText(idtask);
        }
        public string TaskNotfound()
        {
            
            return GetText(msgnotfound);
        }

        
    }
}
