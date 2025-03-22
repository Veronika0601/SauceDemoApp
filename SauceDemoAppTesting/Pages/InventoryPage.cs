
using OpenQA.Selenium;

namespace SauceDemoAppTesting.Pages
{
   public  class InventoryPage :BasePage
    {
        private readonly By productsTitle = By.XPath("//span[text()='Products']");
        private readonly By CartLink = By.CssSelector("[data-test=\"shopping-cart-link\"]");
        private readonly By inventoryItems = By.CssSelector("[class='inventory_item']");


        public InventoryPage(IWebDriver driver) : base(driver) { } 

        public bool IsPageLoaded()
        {
             return GetText(productsTitle) == "Products" && driver.Url.Contains("inventory.html");
        }

        public void AddItemToCartByIndex(int index)
        {

            var ItemAddToCart = By.XPath($"(//div[@class='inventory_item'])[{index}]//button"); 
            Click(ItemAddToCart);
 
        }
        
        public void AddToCartByName(string name)
        {
            var ItemAddToCart = By.XPath($"//div[text()='{name}']/ancestor::div[@class='inventory_item']//button");
            Click(ItemAddToCart);
        }

        public void ClickCartLink()
        {
            Click(CartLink);
        }

        public bool IsInventoryDisplayed()
        {
            return FindElements(inventoryItems).Any();
        }



    }
}
