using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Core;

public abstract class SimpleDriver
{
    public static IWebDriver Driver =>
        //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        new ChromeDriver(@"/Users/daemonica/RiderProjects/AQA_MTS_Learn/SeleniumBasic/Resources/");
}