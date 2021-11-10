using COVID19TheGame.Common;
using COVID19TheGame.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Collections.Generic;


namespace COVID19TheGame.Tests
{
   public class HomePageTests
    {
        IWebDriver driver = null;
        HomePage homePage = null;
        BaseClass b = new BaseClass();
        BattleFieldPage battlepage = null;
        WorkingAtHome workhome = null;

        public HomePageTests()
        {
            homePage = new HomePage(driver);
        }
        [OneTimeSetUp]
        public void initialize()
        {

            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            battlepage = new BattleFieldPage(driver);
            workhome = new WorkingAtHome(driver);

        }
        [Test, Category("Chrome")]
        public void CreateWarriorTest()
        {
            homePage.CovidGameSetup();
            homePage.CreateWarrior("kg");
            homePage.ClickStartJourneyLink();
            Assert.IsTrue(homePage.GetStartJourneyLinkUser().Contains("kg"));
        }
        
        [Test, Category("Chrome")]
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
