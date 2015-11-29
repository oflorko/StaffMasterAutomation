using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaffMasterAutomation;

namespace StaffMasterTests
{
    [TestClass]
    public class BranchTest : BaseTest
    {
        [TestMethod]
        public void CreateBranch()
        {
            BranchesPage.GoTo();
            BranchesPage.CreateNewBranch("NewTestBranch")
                .WithCode().Create();

            BranchesPage.ViewNewBranch("NewTestBranch");

            Assert.AreEqual("NewTestBranch", ViewBranchPage.BranchName, "Names are not matched");
        }

        [TestMethod]
        public void SearchForBranch()
        {
            BranchesPage.GoTo();

            BranchesPage.SearchForBranch("NewTestBranch");

            BranchesPage.ItemAction.View();

            Assert.AreEqual("NewTestBranch", ViewBranchPage.BranchName, "Branch not found");
        }
    }
}
