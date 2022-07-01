using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class ManageBookmarksTest: TestBase
    {
        #region Pages and Flows Objects
        LoginFlows loginFlows;
        ManageBookmarksPage manageBookmarksPage;
        #endregion
        [Test]
        public void ManageBookmarks()
        {
            loginFlows = new LoginFlows();
            manageBookmarksPage = new ManageBookmarksPage();

            #region Parameters
            string username = "administrator";
            string password = "administrator";

            string nome = "novo marcador";
            string descricao = "marcador";
            #endregion
            loginFlows.EfetuarLogin(username, password);

            manageBookmarksPage.Gerenciar();
            manageBookmarksPage.GerenciarMarc();
            manageBookmarksPage.Name(nome);
            manageBookmarksPage.Description(descricao);
            manageBookmarksPage.CriarMarcador();
        }
    }
}