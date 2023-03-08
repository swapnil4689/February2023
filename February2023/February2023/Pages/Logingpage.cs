using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace February2023.Pages
{
    public class Logingpage
    {
        public void LoginActions(IWebDriver driver)
        {
            

            driver.Manage().Window.Maximize();

            //open turnup portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);


            // identify the username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify the password textbox and enter valid password
            IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
            passwordtextbox.SendKeys("123123");
            Thread.Sleep(1500);

            // identify the login button and click on it

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
        }
    }
}
