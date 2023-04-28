using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BankingProject.Practise
{
    [TestClass]
    public class WebElementPrac
    {
        [TestMethod]
        [TestCategory("Web Element Practise")]
        public void TestMethod1()
        {
            //launching the browser
            IWebDriver driver = new ChromeDriver();
            //open the url
            driver.Url = "https://the-internet.herokuapp.com/";
            //getting an elelment
            driver.FindElement(By.XPath("//a[.='Add/Remove Elements']")).Click();
            Console.WriteLine("Element has been clicked");
            IWebElement ele = driver.FindElement(By.XPath("//button"));
            //get text of the element
            String text = ele.Text;
            Console.WriteLine("Text Value of Element is: "+text);
            //check element is displayed or not
            bool rs=ele.Displayed;
            Console.WriteLine("Element has been displayed:   "+rs);
            //check element has bben enabled or not
            bool rs1 = ele.Enabled;
            Console.WriteLine("Element has been enabled : "+rs1);
            //getting element type
            var type=ele.GetType();
            Console.WriteLine(type.FullName);
            //getting font type of an element
            String font=ele.GetCssValue("font");
            Console.WriteLine(font);
            //getting the attribute of an element
            String attr=ele.GetAttribute("type");
            Console.WriteLine(attr);
            driver.Close();
        }
    }
}
