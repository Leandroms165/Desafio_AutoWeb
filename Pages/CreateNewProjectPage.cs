using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class CreateNewProjectPage : PageBase
    {
        By gerenciar = By.XPath("//*[@id='sidebar']/ul/li[7]/a");
        By gerenciarprojetos = By.LinkText("Gerenciar Projetos");
        By criarnovoprojeto = By.XPath("//fieldset/button[@class='btn btn-primary btn-white btn-round']");
        By nomeprojeto = By.Id("project-name");
        By estadoprojeto = By.Id("project-status");
        By descricao = By.Id("project-description");
        By adicionarprojeto = By.XPath("//div/input[@value='Adicionar projeto']");
        By msgsucess = By.XPath("//div/div/div/p[@class='bold bigger-110']");
        By msginvalid = By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/p[1]");

        public void Gerenciar()
        {
            Click(gerenciar);
        }
        public void GerenciarProjetos()
        {
            Click(gerenciarprojetos);
        }
        public void Criarnovoprojeto()
        {
            Click(criarnovoprojeto);
        }
        public void Nomeprojeto(string nome)
        {
            SendKeys(nomeprojeto, nome);
        }
        public void Estadoproejto(string combo)
        {
            ComboBoxSelectByVisibleText(estadoprojeto, combo);
        }
        public void Descricao(string texto)
        {
            SendKeys(descricao, texto);
        }
        public void Buttonaddprojeto()
        {
            Click(adicionarprojeto);
        }
        public string sucess()
        {
            WaitForElement(msgsucess);
            return GetText(msgsucess);
        }
        public string invalid()
        {
            WaitForElement(msginvalid);
            return GetText(msginvalid);
        }
    }
}
