using System;
using OpenQA.Selenium;

namespace StaffMasterAutomation
{
    public class ViewBranchPage
    {
        public static string BranchName
        {
            get
            {
                var branchName =
                    Driver.Instance
                    .FindElement(By.XPath("//tbody/tr[1]/td[2]/input")).GetAttribute("value");
                if (branchName != null)
                    return branchName;
                return String.Empty;
            } 
            
        }
    }
}