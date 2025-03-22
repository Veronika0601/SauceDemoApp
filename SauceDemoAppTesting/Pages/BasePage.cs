

using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SauceDemoAppTesting.Pages
{
    public  class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        public BasePage(IWebDriver driver) 
        {

            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));


        }
    
        protected IWebElement FindElement(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        protected ReadOnlyCollection<IWebElement> FindElements(By locator)
        {

            return driver.FindElements(locator);
        }

        protected void Click(By locator)
        {

            FindElement(locator).Click();
        }

        protected void Type(By locator, string text)
        {
            var element = FindElement(locator);
            element.Clear();
            element.SendKeys(text);

        }

        protected string GetText(By locator)
        {

            return FindElement(locator).Text;
        }


    }
}
