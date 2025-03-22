

using SauceDemoAppTesting.Pages;

namespace SauceDemoAppTesting.Tests
{
     public class CartTests:BaseTest
    {
        [SetUp]

        public void SetUpMethod()
        {
            LoginForm("standard_user", "secret_sauce");
            

            inventoryPage.AddItemToCartByIndex(1);
            inventoryPage.ClickCartLink();


        }
        [Test]
        public void TestCartItemDisplayed()
        {
           

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }
        [Test]
        public void TestClickCheckout()
        {
           

            cartPage.ClickCheckout();
           

           
            Assert.That(checkoutPage.IsPageLoaded,Is.True);


        }
    }
}
