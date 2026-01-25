using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace CSharpSelFramework.Base
{
	public class BaseClass
	{
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--incognito");

            InitBrowser("Chrome");

            //driver.Navigate().GoToUrl("");
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                case "Edge":
                    driver = new EdgeDriver();
                    break;

                case "Safari":
                    driver = new SafariDriver();
                    break;

                default:
                    throw new ArgumentException("Browser not supported");
            }
        }

        //[TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

