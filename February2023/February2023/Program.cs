// open chrome broweser 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();

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

//to check login successfully

IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(hellohari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully");

}
else
{
    Console.WriteLine("Login Failed");
        
};


//navigate to time and material page
IWebElement AdministraionDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]"));
AdministraionDropdown.Click();
Thread.Sleep(2000);

IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();
Thread.Sleep(2000);

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