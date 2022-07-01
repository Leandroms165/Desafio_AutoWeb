using CSharpSeleniumExtentReportNetCoreTemplate.Bases;
using CSharpSeleniumExtentReportNetCoreTemplate.Flows;
using CSharpSeleniumExtentReportNetCoreTemplate.Helpers;
using CSharpSeleniumExtentReportNetCoreTemplate.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSeleniumExtentReportNetCoreTemplate.Tests
{
    [TestFixture]
    public class CreateNewProjectTest: TestBase
    {
        #region Pages and Flows Objects
        LoginFlows loginFlows;
        CreateNewProjectPage createNewProjectPage;

        #endregion
        [Test]
        public void CreateNewProjectSucess()
        {
            loginFlows = new LoginFlows();
            createNewProjectPage = new CreateNewProjectPage();

            #region Parameters
            string username = "administrator";
            string password = "administrator";

            string nameproj = "Novo teste " + GeneralHelpers.ReturnStringWithRandomCharacters(1);
            string state = "release";
            string text = "novo projeto criado";
            string msg = "Operação realizada com sucesso.";
            #endregion
            loginFlows.EfetuarLogin(username, password);

            createNewProjectPage.Gerenciar();
            createNewProjectPage.GerenciarProjetos();
            createNewProjectPage.Criarnovoprojeto();
            createNewProjectPage.Nomeprojeto(nameproj);
            createNewProjectPage.Estadoproejto(state);
            createNewProjectPage.Descricao(text);
            createNewProjectPage.Buttonaddprojeto();
            
            Assert.AreEqual(msg,createNewProjectPage.sucess());

        }
        [Test]
        public void CreateNewProjectInvalid()
        {
            loginFlows = new LoginFlows();
            createNewProjectPage = new CreateNewProjectPage();

            #region Parameters
            string username = "administrator";
            string password = "administrator";

            string nameproj = "1Santander21";
            string state = "release";
            string text = "novo projeto criado";
            string msg = "APPLICATION ERROR #701";
            #endregion
            loginFlows.EfetuarLogin(username, password);

            createNewProjectPage.Gerenciar();
            createNewProjectPage.GerenciarProjetos();
            createNewProjectPage.Criarnovoprojeto();
            createNewProjectPage.Nomeprojeto(nameproj);
            createNewProjectPage.Estadoproejto(state);
            createNewProjectPage.Descricao(text);
            createNewProjectPage.Buttonaddprojeto();

            Assert.AreEqual(msg, createNewProjectPage.invalid());

        }
    }
}
