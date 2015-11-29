using System;
using OpenQA.Selenium;

namespace StaffMasterAutomation
{
    public class ViewStaffPage
    {
        public static string StaffName
        {
            get
            {
                var staffName =
                    Driver.Instance
                    .FindElement(By.XPath("//tbody/tr[1]/td[2]"));
                if (staffName != null)
                    return staffName.Text;
                return String.Empty;
            } 
            
        }
    }
}