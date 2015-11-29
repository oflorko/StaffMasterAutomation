using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StaffMasterAutomation.Navigation;

namespace StaffMasterAutomation
{
    public class BranchesPage
    {
        public static ItemAction ItemAction = new ItemAction();

        public static void GoTo()
        {
            NavigationBar.Entities.Branch.Select();
        }

        public static CreateBranchCommand CreateNewBranch(string title)
        {
            return new CreateBranchCommand(title);
        }

        public static void ViewNewBranch(string title)
        {
            Driver.Wait(TimeSpan.FromSeconds(1));

            var newBranchNewButton = Driver.Instance
                     .FindElement(By.XPath("//tr[td//text()[contains(., 'NewTestBranch')]]//td[4]//button[1]"));
               // .FindElement(By.CssSelector("tr.ng-scope:nth-child(1) > td:nth-child(4) > button:nth-child(1)"));
            
            newBranchNewButton.Click();
        }

        public static void SearchForBranch(string textToSearch)
        {
            var searchField = Driver.Instance.FindElement(By.Id("searchQuery"));
            searchField.SendKeys(textToSearch);

            var searchButton = Driver.Instance.FindElement(By.CssSelector("button.btn-info:nth-child(2)"));
            searchButton.Click();
        }
    }

    public class CreateBranchCommand
    {
        private readonly string title;
        private string code;

        public CreateBranchCommand(string title)
        {
            this.title = title;
        }

        public CreateBranchCommand WithCode(string code)
        {
            this.code = code;
            return this;
        }
        public CreateBranchCommand WithCode()
        {
            Random r = new Random();
            this.code = r.Next(10, 99999).ToString();
            return this;
        }

        public void Create()
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));

            var createNewBranchButton = Driver.Instance.FindElement(By.CssSelector("button.btn-primary:nth-child(1)"));
            createNewBranchButton.Click();

            wait.Until(d => d.FindElement(By.CssSelector(".btn-primary")));
            
            var nameField = Driver.Instance.FindElement(By.CssSelector("div.form-group:nth-child(2) > input:nth-child(2)"));
            nameField.SendKeys(title);

            var codeField = Driver.Instance.FindElement(By.CssSelector("div.form-group:nth-child(3) > input:nth-child(2)"));
            codeField.SendKeys(code);

            var saveBtn = Driver.Instance.FindElement(By.CssSelector("div.modal-footer > .btn-primary"));
            Driver.Wait(TimeSpan.FromSeconds(1));
            saveBtn.Click();
        }
    }
}
