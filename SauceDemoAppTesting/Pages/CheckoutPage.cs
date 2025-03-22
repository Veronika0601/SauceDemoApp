using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SauceDemoAppTesting.Pages
{
    public class CheckoutPage : BasePage
    {

        private readonly By firstNameInput = By.CssSelector("[id='first-name']");

        private readonly By lastNameInput = By.CssSelector("[id='last-name']");

        private readonly By postCodeInput = By.Id("postal-code");

        private readonly By continueButton = By.XPath("//input[@id='continue']");

        private readonly By finishButton = By.XPath("//button[text()='Finish']");

        private readonly By completeHeader = By.XPath("//h2[@class='complete-header']");


        public CheckoutPage(IWebDriver driver) :base (driver){ }

        public void FillFirstName(string firstName)
        {
            Type(firstNameInput, firstName);
        }

        public void FillLastName(string lastName)
        {
            Type(lastNameInput, lastName);
        }

        public void FillPostCode(string postCode)
        {
            Type(postCodeInput, postCode);

        }

        public void ClickContinueButton()
        {
            Click(continueButton);
        }

        public void ClickFinishButton()
        {
            Click(finishButton);
        }

        public bool IsPageLoaded()
        {
            return driver.Url.Contains("checkout-step-one.html") || driver.Url.Contains("checkout-step-two.html");
        }
        
        public bool IsCheckoutComplete()
        {
            return GetText(completeHeader) == "Thank you for your order!";
        }

        public bool IsSecondStepLoaded()
        {

            return driver.Url.Contains("checkout-step-two.html");

        }

        public void FillOrderDetails()
        {
            FillFirstName("John");

            FillLastName("Doe");

            FillPostCode("1000");


           ClickContinueButton();
        }


    }
}
