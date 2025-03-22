using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V131.CSS;
using SauceDemoAppTesting.Pages;

namespace SauceDemoAppTesting.Tests
{
    public class InventoryTests : BaseTest
    {

        [SetUp]
        public void SetUpToLogin()
        {
            LoginForm("standard_user", "secret_sauce");
        }


        [Test]

        public void TestInventoryDisplay()
        {
           

            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True); 
        }
        [Test]
        public void TestAddToCartByIndex()
        {
           

            inventoryPage.AddItemToCartByIndex(1);

            inventoryPage.ClickCartLink();

            //Assert to do
            
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);

        }

        [Test]
        public void TestAddToCartByName()
        {
            
            inventoryPage.AddToCartByName("Sauce Labs Bike Light");
            inventoryPage.ClickCartLink();


            //assert to do

           
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }
        [Test]
        public void TestPageTitle()
        {
            
            Assert.That(inventoryPage.IsPageLoaded(), Is.True);
        }




    }
}
