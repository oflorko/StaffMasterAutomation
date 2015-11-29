using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace StaffMasterAutomation
{
    public class HomePage
    {
        public static bool IsAt 
        {
            get 
            {
                var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                wait.Until(d => d.FindElement(By.CssSelector("h1")));
    
                var h1s = Driver.Instance.FindElements(By.TagName("h1"));
                if (h1s.Count > 0)
                    return h1s[0].Text == "Welcome to Gurukula!";
                return false;
            } 
        }
    }
}
