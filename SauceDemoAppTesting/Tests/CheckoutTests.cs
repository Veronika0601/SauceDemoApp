

using SauceDemoAppTesting.Pages;

namespace SauceDemoAppTesting.Tests
{
    public class CheckoutTests : BaseTest
    {

        [SetUp]

        public void SetUpForCheckout()
        {
            LoginForm("standard_user", "secret_sauce");



            inventoryPage.AddItemToCartByIndex(1);

            inventoryPage.ClickCartLink();



            cartPage.ClickCheckout();

        }
        [Test]
        public void TestCheckoutPageLoaded()
        {



            Assert.That(checkoutPage.IsPageLoaded(), Is.True);
        }
        [Test]

        public void TestContinueToNextStep()
        {


            checkoutPage.FillOrderDetails();

            Assert.That(checkoutPage.IsSecondStepLoaded(), Is.True);
        }
        [Test]

        public void TestCompleteOrder()
        {

            checkoutPage.FillOrderDetails();

            checkoutPage.ClickFinishButton();

            Assert.That(checkoutPage.IsCheckoutComplete(), Is.True);
        }
    }
}
