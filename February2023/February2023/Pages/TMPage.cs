using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(2000);

            //click on type code dropdown
            IWebElement typtCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typtCode.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //input code into code textbox
            IWebElement codeTextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTextbox.SendKeys("February2023");

            //input Description in description textbox
            IWebElement descripton = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            descripton.SendKeys("February2023");

            // input value in price per unit textbox
            IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            price.SendKeys("123");
            Thread.Sleep(2000);

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //go to last page
            IWebElement goTolastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goTolastpage.Click();
            Thread.Sleep(4000);

            //Check if the time record has been created
            IWebElement newTimerecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newTimerecord.Text == "February2023")
            {
                Console.WriteLine("Record Created successfully");
            }
            else
            {
                Console.WriteLine("Record hasn't been created");
            }
        }
        
        public void EditTM(IWebDriver driver) 
        {

        }
        
        public void DeleteTM(IWebDriver driver)
        {

        }

    }
}
