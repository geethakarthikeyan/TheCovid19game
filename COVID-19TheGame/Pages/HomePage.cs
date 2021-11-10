using COVID19TheGame.Common;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace COVID19TheGame.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver d)
        {
            driver = d;
        }
        public HomePage()
        {

        }
        #region Elements
        private IWebElement UsernameInputBox => driver.FindElement(By.Id("worrior_username"));
        private IWebElement CreateWarriorLink => driver.FindElement(By.XPath("//a[@id='warrior']"));
        private IWebElement StartJourneyLink => driver.FindElement(By.XPath("//a[@id='start']"));
        private IWebElement WelcomeText => driver.FindElement(By.Id("welcome_text"));
        #endregion
        #region Methods
        
        public HomePage CovidGameSetup()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = Driver.ConfiguredCovidGameURL;
            return this;
        }
        public void CreateWarrior(string user)
        {
            UsernameInputBox.SendKeys(user);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            CreateWarriorLink.Click();

        }
        public void ClickStartJourneyLink()
        {
            Thread.Sleep(3000);
            StartJourneyLink.Click();
        }
        public string GetStartJourneyLinkUser()
        {
            return WelcomeText.Text;
        }
        public void Close()
        {
            driver.Close();
        }
        #endregion
    }
}
