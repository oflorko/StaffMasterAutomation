using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaffMasterAutomation;

namespace StaffMasterTests
{
    [TestClass]
    public class LoginTest : BaseTest
    {
        [TestMethod]
        public void AdminUserCanLogin()
        {
            Assert.IsTrue(HomePage.IsAt, "Failed to login");
        }

    }
}
