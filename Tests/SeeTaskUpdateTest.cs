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
    public class SeeTaskUpdateTest: TestBase
    {
        #region Page an Flows Objects
        LoginFlows loginFlows;
        MainPage mainPage;
        SeeTaskUpdatePage seeTaskUpdatePage;
        #endregion

        [Test]
        public void UpdateTask()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            seeTaskUpdatePage = new SeeTaskUpdatePage();

            #region Parameters
            string username = "administrator";
            string password = "administrator";
            string textresumo = "update";
            string novoTextDescription = "erro tela";
            #endregion

            loginFlows.EfetuarLogin(username, password);

            seeTaskUpdatePage.Buttonseetask();

            seeTaskUpdatePage.ClickupdateTask();
            seeTaskUpdatePage.ClickButtonupdate();

            seeTaskUpdatePage.ClearCampoResumo();
            seeTaskUpdatePage.UpdateCampoResumo(textresumo);

            seeTaskUpdatePage.ClearDescription();
            seeTaskUpdatePage.UpdateDescription(novoTextDescription);
        }

        [Test]
        public void MsgUpdateInvalid()
        {
            loginFlows = new LoginFlows();
            mainPage = new MainPage();
            seeTaskUpdatePage = new SeeTaskUpdatePage();

            #region Parametrs
            string username = "administrator";
            string password = "administrator";
            var text = "APPLICATION ERROR #11\r\n" +
                "Um campo necessário 'Resumo' estava vazio. Por favor, verifique novamente suas entradas.\r\nPor favor, utilize o botão \"Voltar\" de seu navegador web para voltar à " +
                "pagina anterior. Lá você pode corrigir quaisquer problemas identificados neste erro ou escolher uma outra ação. Você também pode clicar em uma opção da barra de menus para ir diretamente para outra seção." ;
            #endregion

            loginFlows.EfetuarLogin(username, password);

            seeTaskUpdatePage.Buttonseetask();

            seeTaskUpdatePage.ClickupdateTask();
            seeTaskUpdatePage.ClickButtonupdate();

            seeTaskUpdatePage.ClearCampoResumo();
            seeTaskUpdatePage.ClearDescription();

            seeTaskUpdatePage.Buttonupdate();

            Assert.AreEqual(text, seeTaskUpdatePage.MsgUpdateInvalid());
        }
    }
}