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
    public class SeeTaksTeste : TestBase
    {
        #region Pages and Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        SeeTaksPage seeTaksPage;
        #endregion

        [Test]
        public void SeeTask()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            seeTaksPage = new SeeTaksPage();

            #region Parameters
            string username = "administrator";
            string password = "administrator";
            string textoresumo = "0000123: Resumo testeCBWUD";
            string textodescricao = "Teste automatico";
            #endregion

            loginFlows.EfetuarLogin(username, password);

            seeTaksPage.ButtonSeeTaks();
            seeTaksPage.ClickId();

            Assert.AreEqual(textoresumo, seeTaksPage.Resumo());
            Assert.AreEqual(textodescricao, seeTaksPage.Description());
        }
    }
}