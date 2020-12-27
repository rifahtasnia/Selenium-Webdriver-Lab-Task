using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Testing
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://elp.duetbd.org/";

            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='header']/div/ul/li[2]/div/span/a"));
            element1.Click();

            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("170042042");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("Rifah.42");
            driver.FindElement(By.Id("loginbtn")).Click();
            string at = driver.Title;

            string et = "Dashboard";                            
            if (at == et)
            {
                Console.WriteLine("Test Successful");            
            }
            else
            {
                Console.WriteLine("Unsuccessful");              
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
