using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class SeeTaskUpdatePage : PageBase
    {
        By buttonSeeTask = By.XPath("//*[@id='sidebar']/ul/li[2]/a");
        By idupdateTask = By.LinkText("0000104");
        By buttonUpdate = By.XPath("//fieldset/input[@value='Atualizar']");
        By descriptionResumo = By.XPath("//tr/td/input[@id='summary']");
        By NovoTextResumo = By.XPath("//tr/td/input[@id='summary']");
        By description = By.XPath("//tr/td/textarea[@id='description']");
        By updateDescription = By.XPath("//tr/td/textarea[@id='description']");
        By textinvalida = By.XPath("//div/div/div/div/div/div[@class='alert alert-danger']");
        By buttonatualizar = By.XPath("//div/input[@class='btn btn-primary btn-white btn-round']");

        public void Buttonseetask()
        {
            Click(buttonSeeTask);
        }
        public void ClickupdateTask()
        {
            Click(idupdateTask);
        }
        public void ClickButtonupdate()
        {
            Click(buttonUpdate);
        }
        public void ClearCampoResumo()
        {
            ClearElement(descriptionResumo);

        }
        public void UpdateCampoResumo(string novoTextResumo)
        {
            SendKeys(NovoTextResumo, novoTextResumo);
        }
        public void ClearDescription()
        {
            ClearElement(description);
        }
        public void UpdateDescription(string novoTextDescription)
        {
            SendKeys(updateDescription, novoTextDescription);
        }
        public void Buttonupdate ()
        {
            Click(buttonatualizar);
        }
        public string MsgUpdateInvalid()
        {
            return GetText(textinvalida);
        }

    }
}
