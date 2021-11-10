using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace COVID19TheGame.Common
{
    public class BaseClass
    {
        protected IWebDriver driver;
        public void Setup(string browserName)
        {
            if (browserName.Equals("chrome"))
                driver = new ChromeDriver();
            else if (browserName.Equals("firefox"))
                driver = new FirefoxDriver();

            else
                driver = new EdgeDriver();
        }
        [TearDown]
        public void cleanUp()
        {
            driver.Quit();
        }
    }
}
