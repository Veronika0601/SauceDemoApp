using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauceDemoAppTesting.Pages;

namespace SauceDemoAppTesting.Tests
{
    public class LoginTests : BaseTest
    {

        [Test]

        public void TestLoginWithValidCredentials()
        {
            LoginForm("standard_user", "secret_sauce");



            Assert.That(inventoryPage.IsPageLoaded, Is.True, "Login was not unsuccessful");

        }
        [Test]
        public void TestLoginWithInvalidCredentials()
        {

            LoginForm("invaliduser", "invalid");



            string errorMessage = loginPage.GetErrorMessage();

            Assert.That(errorMessage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "User is able to login");


        }
        [Test]

        public void TestLoginWithLockedOutUser()
        {
            LoginForm("locked_out_user", "secret_sauce");


            string messageForLockedUser = loginPage.GetErrorMessage();

            Assert.That(messageForLockedUser, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }
    }
}
