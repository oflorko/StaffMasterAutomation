using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaffMasterAutomation;

namespace StaffMasterTests
{
    [TestClass]
    public class StaffTest : BaseTest
    {
        [TestMethod]
        public void ListStaffs()
        {
            StaffPage.GoTo();

            Assert.IsTrue(StaffPage.IsAt);
        }

        [TestMethod]
        public void CreateNewStaff()
        {
            StaffPage.GoTo();

            StaffPage.CreateNewStaff("Name").Create();

            StaffPage.SearchForStaff("Name");

            Assert.AreEqual("Name", ViewStaffPage.StaffName, "Names are not matched");
        }
    }
}
