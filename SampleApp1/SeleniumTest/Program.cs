using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Program
    {
        public IWebDriver driver;

        static void Main(string[] args)
        {
            //Program prg = new Program();
            //prg.startBrowser();
            //prg.test();
        }

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"C:\temp");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://localhost:50093"; /*"https://jenkinstestseleniumapp.azurewebsites.net";*/
            //driver.FindElement(By.Name("q")).SendKeys("Azure Portal");
            Assert.True(driver.FindElement(By.Name("btnK")).Text == "Learn more »");
            //closeBrowser();
           // Assert.True(1==1);
        }

        //[TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
