using OpenQA.Selenium;

namespace StaffMasterAutomation.Navigation
{
    public class ItemAction
    {
        public void View()
        {
            var viewBtn = Driver.Instance.FindElement(By.CssSelector("tr.ng-scope:nth-child(1) > td:nth-child(4) > button:nth-child(1)"));
            viewBtn.Click();
        }

        public void Edit()
        {
            var editBtn = Driver.Instance.FindElement(By.CssSelector("tr.ng-scope:nth-child(1) > td:nth-child(4) > button:nth-child(2)"));
            editBtn.Click();
        }

        public void Delete()
        {
            var deleteBtn = Driver.Instance.FindElement(By.CssSelector("tr.ng-scope:nth-child(1) > td:nth-child(4) > button:nth-child(3)"));
            deleteBtn.Click();
        }
    }
}
