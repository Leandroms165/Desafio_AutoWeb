using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class SeeTaksPage : PageBase
    {
        By buttonSeeTaks = By.XPath("//*[@id='sidebar']/ul/li[2]/a");
        By idTask = By.LinkText("0000123");
        By fielddResumo = By.CssSelector("td[class='bug-summary']");
        By bugdescription = By.CssSelector("td[class='bug-description']");

        public void ButtonSeeTaks()
        {
            Click(buttonSeeTaks);
        }

        public void ClickId()
        {
            Click(idTask);
        }
        public string Resumo()
        {
            return GetText(fielddResumo);
        }

        public string Description()
        {
            return GetText(bugdescription);
        }

    }
}
