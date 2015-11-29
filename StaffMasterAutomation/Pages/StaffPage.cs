using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace StaffMasterAutomation
{
    public class StaffPage
    {
        public static void GoTo()
        {
            NavigationBar.Entities.Staff.Select();
        }

        public static bool IsAt
        {
            get
            {
                var staffTable = Driver.Instance.FindElements(By.CssSelector("h2.ng-scope"));
                if (staffTable.Count > 0)
                    return staffTable[0].Text == "Staffs";
                return false;
            }
        }

        public static CreateNewStaffCommand CreateNewStaff(string name)
        {
            return new CreateNewStaffCommand(name);
        }

        public static void SearchForStaff(string textToSearch)
        {
            Driver.Wait(TimeSpan.FromSeconds(1));

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => Driver.Instance.FindElement(By.CssSelector("button.btn-info:nth-child(2)")));

            var searchField = Driver.Instance.FindElement(By.Id("searchQuery"));
            searchField.SendKeys(textToSearch);

            Driver.Wait(TimeSpan.FromSeconds(1));

            var searchButton = Driver.Instance.FindElement(By.CssSelector("button.btn-info:nth-child(2)"));
            searchButton.Click();
        }
    }

    public class CreateNewStaffCommand
    {
        private readonly string name;
        private string selectedBranch;

        public CreateNewStaffCommand(string name)
        {
            this.name = name;
        }

        public void Create()
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));

            var createNewBranchButton = Driver.Instance.FindElement(By.CssSelector("button.btn-primary:nth-child(1)"));
            createNewBranchButton.Click();

            wait.Until(d => d.FindElement(By.CssSelector(".btn-primary")));

            var nameField = Driver.Instance.FindElement(By.CssSelector("input.ng-invalid"));
            nameField.SendKeys(name);

            SelectElement branchDropDown = new SelectElement(Driver.Instance.FindElement(By.CssSelector("select.form-control")));
            branchDropDown.SelectByText("NewTestBranch");

            var saveBtn = Driver.Instance.FindElement(By.CssSelector("form.ng-valid-pattern > div:nth-child(3) > button:nth-child(2)"));
            Driver.Wait(TimeSpan.FromSeconds(1));
            saveBtn.Click();
        }
    }
}


