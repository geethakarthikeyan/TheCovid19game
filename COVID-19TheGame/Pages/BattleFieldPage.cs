using OpenQA.Selenium;

namespace COVID19TheGame.Pages
{
    public class BattleFieldPage : HomePage
    {
        private IWebDriver driver;

        public BattleFieldPage(IWebDriver d) : base(d)
        {
            this.driver = d;
        }
        
        #region Elements
        private IWebElement GoToTheOfficeLink => driver.FindElement(By.Id("office"));
        private IWebElement UsernameInputBox => driver.FindElement(By.Id("worrior_username"));
        private IWebElement CreateWarriorLink => driver.FindElement(By.XPath("//a[@id='warrior']"));
        private IWebElement StartJourneyLink => driver.FindElement(By.XPath("//a[@id='start']"));
        private IWebElement WelcomeText => driver.FindElement(By.Id("welcome_text"));
        #endregion
        #region Methods
        public void ClickGoToTheOffice()
        {
            GoToTheOfficeLink.Click();
        }
        //public BattleFieldPage CovidGameSetup()
        //{
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    driver.Url = Driver.ConfiguredCovidGameURL;
        //    return this;
        //}
        //public void CreateWarrior(string user)
        //{
        //    UsernameInputBox.SendKeys(user);
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        //    CreateWarriorLink.Click();

        //}
        //public void ClickStartJourneyLink()
        //{
        //    Thread.Sleep(3000);
        //    StartJourneyLink.Click();
        //}
        //public string GetStartJourneyLinkUser()
        //{
        //    //var element = driver.FindElement(By.Id("welcome_text"));
        //    //IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
        //    //je.ExecuteScript("arguments[0].scrollIntoview(false);", element);
        //    return WelcomeText.Text;
        //}
        #endregion

    }
}
