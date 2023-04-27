using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;

namespace BankingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Launching browser")]
        public void TestMethod1()
        {
            //launching the browser
            IWebDriver driver = new ChromeDriver();
            //opening the URL
            driver.Url = "https://www.google.com/";
            //maximize the window
            driver.Manage().Window.Maximize();
            //getting pagesource
            var data=driver.PageSource;
            Console.WriteLine(data);
            Console.WriteLine("----------------------------------------");
            //getting the title of the web page
            var title= driver.Title;
            Console.WriteLine("Title of the page is:  "+title);
            Console.WriteLine("----------------------------------------");

            //address of the wiindow
            var windowID = driver.CurrentWindowHandle;
            Console.WriteLine("Window Id is :"+windowID);
            Console.WriteLine("----------------------------------------");

            //var element = driver.FindElement(By.Name(""));
        }

    }
}
