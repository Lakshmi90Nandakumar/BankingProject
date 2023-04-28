using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BankingProject.Practise
{
    [TestClass]
    public class AuthendicationPrac
    {
        [TestMethod]
        [TestCategory("to handle authendication pop up")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://admin:admin@the-internet.herokuapp.com/basic_auth";
            String text=driver.FindElement(By.XPath("//a[contains(.,'Elemental Selenium')]")).Text;
            if(text.Contains("Selenium"))
            {
              Console.WriteLine("Successfully logggedin");
            
            }
            else
            {
                Console.WriteLine("Not Successful");
            }
        }
    }
}
