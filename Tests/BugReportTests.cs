using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using Google.Apis.Admin.Directory.directory_v1.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class BugReportTests : TestBase
    {
        #region Page and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        BugReportPage bugReportPage;
        #endregion
        
        [Test]
        public void BugReportSucess()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            bugReportPage = new BugReportPage();

            #region Parameters
            string username = "administrator";
            string password = "password";
            string categoria = "[Todos os Projetos] General";
            string resumo = "Resumo teste" + GeneralHelpers.ReturnStringWithRandomCharacters(5);
            string descricao = "Teste automatico";
            string caminhoArquivo = GeneralHelpers.ReturnProjectPath() + "Resources/Files/Erro.jpg";
            #endregion

            loginFlows.EfetuarLogin(username, password);
            loginFlows.
           
            mainPage.ClicarEmReportIssue();

            bugReportPage.SelecionarCategoria(categoria);
            bugReportPage.PreencherResumo(resumo);
            bugReportPage.PreencherDescricao(descricao);
            bugReportPage.InserirAnexo(caminhoArquivo);
            bugReportPage.ClicarEmSubmitReport();
        }

    }
}