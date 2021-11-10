using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace COVID19TheGame.Pages
{
    public class WorkingAtHome
    {
            private IWebDriver driver;

            public WorkingAtHome(IWebDriver d)
            {
                driver = d;
            }

            #region Elements
            private IWebElement WorkingAtHomePopup => driver.FindElement(By.Id("officeWorker"));
            private IWebElement WorkingAtHomeStartButton => driver.FindElement(By.XPath("//button[@id='start']"));
            private IWebElement Question1Answer => driver.FindElement(By.Id("office_answer_1"));
            private IWebElement TryNextBattleButton => driver.FindElement(By.XPath("//button[text()='Try the next battle']"));
            private IWebElement LeaderBoardButton => driver.FindElement(By.Id("leaderboard_link"));
            private IWebElement BusStartButton => driver.FindElement(By.Id("bus_timer_start"));
            private IWebElement LeaderBoardUsername => driver.FindElement(By.XPath("//td[text()='kg']"));
            private IWebElement LeaderBoardScore => driver.FindElement(By.XPath("//td[text()='kg']/following-sibling::td"));
            private IWebElement AtPublicbusHeading => driver.FindElement(By.XPath("//h5[text()='You have taken the public bus..']"));
            private IWebElement PublicBusWrongAnswer => driver.FindElement(By.Id("bus_answer_2"));
            private IWebElement PublicBusRightAnswer => driver.FindElement(By.Id("bus_answer_1"));  
            private IWebElement WrongAnswerHeading => driver.FindElement(By.XPath("//h5[text()='That doesn't sound right!']"));
            private IWebElement TryAgainButton => driver.FindElement(By.Id("close_incorrect_modal_btn"));
            #endregion
            #region Methods
            public string GetTextForWorkingAtHomePopup()
            {
                 return WorkingAtHomePopup.GetAttribute("alt");
            }
            public void AtTheOfficeQuiz()
            {
            WorkingAtHomeStartButton.Click();
            Question1Answer.Click();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            TryNextBattleButton.Click();
            }
            public void AtPublicBusQuiz()
            {
            Assert.IsTrue(AtPublicbusHeading.Displayed);
            BusStartButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            PublicBusWrongAnswer.Click();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            TryAgainButton.Click();
            PublicBusRightAnswer.Click();
            }
            public void CheckScoreInLeaderBoard()
            {
            LeaderBoardButton.Click();
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//td[text()='kg']")));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + LeaderBoardUsername + "' was not found in current context page.");
                throw;
            }
            Assert.IsTrue(LeaderBoardScore.Displayed);
        }

        
            #endregion    
    

}
}
