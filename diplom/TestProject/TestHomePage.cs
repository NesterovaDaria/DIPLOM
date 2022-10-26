using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject
{
    [TestClass]
    public class TestHomePage
    {
        readonly IWebDriver Driver = new ChromeDriver();

        public void TestMethod_URLHomePage()
        {
            Driver.Url = "https://localhost:44317/";
            Driver.FindElement(By.Id("btnEnter")).Click();
            try {
                Assert.AreEqual("¬ход", Driver.Title);
                Console.WriteLine("—сылка на страницу ¬ход работает правильно");
            }
            catch (Exception) { Console.WriteLine("Exception"); throw; }

            Driver.Navigate().Back();
            try
            {
                Assert.AreEqual("√лавна€ - WebPortalLanguages", Driver.Title);
                Console.WriteLine("—сылка назад работает правильно");
            }
            catch (Exception) { Console.WriteLine("Exception"); throw; }

            Driver.FindElement(By.Id("btnReg")).Click();
            try
            {
                Assert.AreEqual("–егистраци€", Driver.Title);
                Console.WriteLine("—сылка на страницу –егистраци€ работает правильно");
            }
            catch (Exception) { Console.WriteLine("Exception"); throw; }

            Driver.Navigate().Back();
            try
            {
                Assert.AreEqual("√лавна€ - WebPortalLanguages", Driver.Title);
                Console.WriteLine("—сылка назад работает правильно");
            }
            catch (Exception) { Console.WriteLine("Exception"); throw; }
        }
    }
}