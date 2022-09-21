using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriveHelper
    {

        public static void Login(string userName, string password, string value1, string value2)
        {
            Driver.FindElement(By.Id($"{userName}")).SendKeys($"{value1}");
            Driver.FindElement(By.Id($"{password}")).SendKeys($"{value2}");
            Driver.FindElement(By.Id("login-button")).Click();
        }
    }
}
