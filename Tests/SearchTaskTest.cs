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
    public class SearchTaskTest: TestBase
    {
        #region Page and Flows Objects
        LoginFlows loginFlows;
        SearchTaskPage searchTaskPage;
        #endregion

        [Test]
        public void SearchTaks()
        {
            loginFlows = new LoginFlows();
            searchTaskPage = new SearchTaskPage();

            #region Parameters
            string username = "administrator";
            string password = "administrator";
            string search = "0000124";
            
            #endregion

            loginFlows.EfetuarLogin(username,password);

            searchTaskPage.Searchtask(search);
            searchTaskPage.ClicandoEnter();

            Assert.AreEqual(search, searchTaskPage.ValidSearch());
        }
        [Test]
        public void Taskinvalid()
        {
            loginFlows = new LoginFlows();
            searchTaskPage = new SearchTaskPage();

            #region Parameters
            string username = "administrator";
            string password = "administrator";
            string search = "870";
            string msgtaskinvalid = "APPLICATION ERROR #1100\r\n" +
                "A tarefa 870 não encontrada.\r\n" +
                "Por favor, utilize o botão \"Voltar\" de seu navegador web para voltar à pagina anterior. Lá você pode corrigir quaisquer problemas identificados neste erro ou escolher uma outra ação. Você também pode clicar em uma opção da barra de menus para ir diretamente para outra seção.";
            #endregion

            loginFlows.EfetuarLogin(username, password);
            searchTaskPage.Searchtask(search);
            searchTaskPage.ClicandoEnter();

            Assert.AreEqual(msgtaskinvalid, searchTaskPage.TaskNotfound());

        }

    }
}