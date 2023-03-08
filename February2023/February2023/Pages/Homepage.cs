using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Pages
{
    public class Homepage
    {
        public void GoToTMpage(IWebDriver driver)
        {

            //navigate to time and material page
            IWebElement AdministraionDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]"));
            AdministraionDropdown.Click();
            Thread.Sleep(2000);

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
            Thread.Sleep(2000);
        }
    }
}
