using COVID19TheGame.Common;
using COVID19TheGame.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19TheGame.Tests
{
    public class BattleFieldTestEdge
    {
        IWebDriver driver = null;
        HomePage homePage = null;
        BaseClass b = new BaseClass();
        BattleFieldPage battlepage = null;
        WorkingAtHome workhome = null;

        public BattleFieldTestEdge()
        {
            homePage = new HomePage(driver);
        }
        [OneTimeSetUp]
        public void initialize()
        {

            driver = new EdgeDriver();
            homePage = new HomePage(driver);
            battlepage = new BattleFieldPage(driver);
            workhome = new WorkingAtHome(driver);

        }
        [Test, Category("Edge")]
        public void CreateWarriorTest()
        {
            homePage.CovidGameSetup();
            homePage.CreateWarrior("kg");
            homePage.ClickStartJourneyLink();
            Assert.IsTrue(homePage.GetStartJourneyLinkUser().Contains("kg"));
        }

        [Test, Category("Edge")]
        public void AttemptBattleTest()
        {
            homePage.CovidGameSetup();
            homePage.CreateWarrior("kg");
            homePage.ClickStartJourneyLink();
            Assert.IsTrue(homePage.GetStartJourneyLinkUser().Contains("kg"));
            battlepage.ClickGoToTheOffice();
            string ActualText = workhome.GetTextForWorkingAtHomePopup();
            Assert.AreEqual("working at home", ActualText);
            workhome.AtTheOfficeQuiz();
            workhome.AtPublicBusQuiz();
            workhome.CheckScoreInLeaderBoard();
        }
        [TearDown]
        public void close()
        {
            driver.Quit();
        }

    }
}
