using OpenQA.Selenium;
using SeleniumBasic.Core;
using SeleniumBasic.Utilites.Configuration;

namespace SeleniumBasic.Tests;

public class BaseTest
{
    protected IWebDriver Driver { get; set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
        Driver.Navigate().GoToUrl(Configurator.AppSettings.Url);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}