using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class ManageBookmarksPage: PageBase
    {
        By gerenciar = By.XPath("//*[@id='sidebar']/ul/li[7]/a");
        By gerenciarMarcadores = By.LinkText("Gerenciar Marcadores");
        By nome = By.Id("tag-name");
        By descri = By.Id("tag-description");
        By buttoncriar = By.Name("config_set");

        public void Gerenciar()
        {
            Click(gerenciar);
        }
        public void GerenciarMarc()
        {
            Click(gerenciarMarcadores);
        }
        public void Name(string nom)
        {
            SendKeys(nome, nom);
        }
        public void Description(string descricao)
        {
            SendKeys(descri,descricao);
        }
        public void CriarMarcador()
        {
            Click(buttoncriar);
        }
    }
}
