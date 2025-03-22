
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SauceDemoAppTesting.Pages
{
    public class CartPage:BasePage
    {
        private readonly By cartItems = By.XPath("//div[@class='cart_item']");

        private readonly By checkoutButton = By.XPath("//button[@id='checkout']");

        public CartPage(IWebDriver driver) : base(driver) { }

        public bool IsCartItemDisplayed()
        {
            return FindElement(cartItems).Displayed;


        }

        public void ClickCheckout()
        {
            Click(checkoutButton);
        }


    }
}
