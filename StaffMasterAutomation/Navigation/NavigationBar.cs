using System;
using OpenQA.Selenium;

namespace StaffMasterAutomation
{
    public class NavigationBar
    {
        public class Entities
        {
            public static void ClickOnEntities()
            {
                var entitiesMenu = Driver.Instance.FindElement(By.LinkText("Entities"));
                entitiesMenu.Click();

                Driver.Wait(TimeSpan.FromSeconds(1));
            }

            public class Branch
            {
                public static void Select()
                {
                    ClickOnEntities();

                    var branchPage =
                        Driver.Instance.FindElement(By.CssSelector("li.dropdown:nth-child(3) > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1) > span:nth-child(2)"));

                    branchPage.Click(); 
                }
            }

            public class Staff
            {
                public static void Select()
                {
                    ClickOnEntities();

                    var branchPage =
                        Driver.Instance.FindElement(By.CssSelector("li.dropdown:nth-child(3) > ul:nth-child(2) > li:nth-child(2) > a:nth-child(1) > span:nth-child(2)"));

                    branchPage.Click();
                }
            }
        }
    }
}
