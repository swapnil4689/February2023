

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using February2023.Pages;

// open chrome broweser 

IWebDriver driver = new ChromeDriver();

//Login page object intilisation and defination

Logingpage LoginPageobject = new Logingpage();
LoginPageobject.LoginActions(driver);


//Home page object intilisation and defination

Homepage homepageObj = new Homepage();
homepageObj.GoToTMpage(driver);

// TMpage object intilisation and defination

TMPage TmPageobj = new TMPage();
TmPageobj.CreateTM(driver);

//Edit TM
TmPageobj.EditTM(driver);

//Delete TM
TmPageobj.DeleteTM(driver);
 








