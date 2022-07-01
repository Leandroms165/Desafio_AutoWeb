using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Pages
{
    public class BugReportPage : PageBase
    {
        #region Mapping
        By selecionarProjeto = By.XPath("//input[@type='submit']");
        By categoryComboBox = By.Name("category_id");
        By summaryField = By.Name("summary");
        By descriptionField = By.Name("description");
        By uploadFileField = By.XPath("//td/div[@class='dropzone center dz-clickable']");
        By submitButton = By.XPath("//input[@type='submit']");
        By msgsucesso = By.XPath("/html/body/div[2]");
        #endregion

        #region Actions
        public void SelecionarProjeto()
        {
            Click(selecionarProjeto);
        }

        public void SelecionarCategoria(string categoria)
        {
            ComboBoxSelectByVisibleText(categoryComboBox, categoria);
        }
        
        public void PreencherResumo(string resumo)
        {
            SendKeys(summaryField, resumo);
        }

        public void PreencherDescricao(string descricao)
        {
            SendKeys(descriptionField, descricao);
        }

        public void InserirAnexo(string caminhoArquivo)
        {
            SendKeysWithoutWaitVisible(uploadFileField, caminhoArquivo);
           
        }

        public void ClicarEmSubmitReport()
        {
            Click(submitButton);
        }

        public string MsgSucess()
        {
            return GetText(msgsucesso);
        }
        
        #endregion
    }
}