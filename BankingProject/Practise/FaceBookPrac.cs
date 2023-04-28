using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Practise
{
    [TestClass]
    public class FaceBookPrac
    {
        [TestMethod]
        [TestCategory("facebookAutomation")]
        public void testMethod()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[contains(.,'Create new account')]")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys("lakshmi");
            driver.FindElement(By.Name("lastname")).SendKeys("nanda");
            driver.FindElement(By.Name("reg_email__")).SendKeys("lakshminanda@gmail.com");
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("lakshminanda@gmail.com");
            driver.FindElement(By.Id("password_step_input")).SendKeys("Nanda@123");
            IWebElement day=driver.FindElement(By.Name("birthday_day"));
            SelectElement s=new SelectElement(day);
            s.SelectByText("10");
            IWebElement month = driver.FindElement(By.Name("birthday_month"));
            SelectElement s1 = new SelectElement(month);
            s1.SelectByText("May");
            IWebElement year = driver.FindElement(By.Name("birthday_year"));
            SelectElement s2 = new SelectElement(year);
            s2.SelectByText("1990");
            driver.FindElement(By.XPath("//label[text()='Female']")).Click();
            driver.FindElement(By.Name("websubmit")).Click();
            driver.FindElement(By.XPath("//span[contains(.,'Continue')]")).Click();


        }
    }
}