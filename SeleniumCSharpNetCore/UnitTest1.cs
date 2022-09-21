using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriveHelper
    {
      

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");

            Driver = new ChromeDriver();
        }
            

        [Test]
        public void Test1()
        {
            Driver.Navigate()
                .GoToUrl("https://www.saucedemo.com/");

            CustomControl.Login("user-name", "password", "standard_user", "secret_sauce");

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}