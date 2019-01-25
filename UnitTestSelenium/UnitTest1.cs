using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace UnitTestSelenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
         
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://test.zbizlink.com");

        }
    }
}
