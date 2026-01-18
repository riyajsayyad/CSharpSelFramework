using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpSelFramework.Base
{
	public class BaseClass
	{
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");

            driver = new ChromeDriver(options);
            //driver.Navigate().GoToUrl("");
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
        }
    }
}

