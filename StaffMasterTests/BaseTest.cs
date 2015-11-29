using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaffMasterAutomation;

namespace StaffMasterTests
{
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("admin").WithPasword("admin").Login();
        }

        [TestCleanup]
        public void Cleanup()
        {
            //Driver.Close();
        }
    }
}
