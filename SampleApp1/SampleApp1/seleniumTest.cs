using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApp1
{
    public class seleniumTest
    {
        IWebDriver driver;
        static void Main(string[] ss) {

        }
       
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
        }
       
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }
       
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}