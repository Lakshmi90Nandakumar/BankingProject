using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    [TestClass]
    public class Unit_test
    {
        [TestMethod]
        [TestCategory("Web Element methods")]
        public void TestMethod()

        {
            //lauching browser
            IWebDriver driver=new ChromeDriver();
            //entering to the application
            driver.Url = "https://secure.indeed.com/";
            //synchronization 
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            //click on goole window
            var google=driver.FindElement(By.XPath("//span[@class='css-zneog5 e1wnkr790' and text()='Continue with Google']"));
            google.Click();
            //click on apple tab
            var apple = driver.FindElement(By.XPath("//span[@class='css-zneog5 e1wnkr790' and text()='Continue with Apple']"));
            apple.Click();
            //click on facebook tab
            var faceBook = driver.FindElement(By.XPath("//span[@class='css-zneog5 e1wnkr790' and text()='Continue with Facebook']"));
            faceBook.Click();
            var allWh=driver.WindowHandles;
            foreach(var wh in allWh) 
            {
                String title=driver.Title;
                if(title.Contains("Sign in – Google accounts"))
                {
                    driver.SwitchTo().Window(wh);//switch to google window
                }
              
            }
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("lakshmi.chitrait@gmail.com");
           
        }

    }
}
