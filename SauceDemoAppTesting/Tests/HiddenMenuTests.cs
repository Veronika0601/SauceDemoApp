
using SauceDemoAppTesting.Pages;

namespace SauceDemoAppTesting.Tests
{
     public class HiddenMenuTests: BaseTest
    {

        [SetUp]

        public void SetUpforLogin()
        {
            LoginForm("standard_user", "secret_sauce");
        }
        [Test]

        public void TestOpenMenu()
        {
            

            hiddenMenuPage.ClickMenuButton();

            Assert.That(hiddenMenuPage.IsMenuOpen, Is.True);

        }

        [Test]

        public void TestLogout()
        {
          
            hiddenMenuPage.ClickMenuButton();

            hiddenMenuPage.ClickLogoutButton();

            Assert.That(driver.Url,Is.EqualTo("https://www.saucedemo.com/"));
        }
    }
}
