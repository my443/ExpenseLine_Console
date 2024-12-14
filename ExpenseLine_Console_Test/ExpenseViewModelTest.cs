using ExpenseLine_Console.ViewModels;

namespace ExpenseLine_Console_Test
{
    [TestClass]
    public sealed class ExpenseViewModelTest
    {
        private ExpenseViewModel _expenseViewModel;

        [TestInitialize]
        public void Setup()
        {
            _expenseViewModel = new ExpenseViewModel();
        }

        [TestMethod]
        public void TestExpenseViewModelDefaults()
        {
            Assert.AreEqual(_expenseViewModel.GetCanApprove(), false, "By Default user cannot approve.");
            Assert.AreEqual(_expenseViewModel.GetCanProcess(), false, "By Default user cannot process.");
        }

        [TestMethod]
        public void TestSettingCanApproveToTrue()
        {
            _expenseViewModel.SetCanApprove(true);
            Assert.AreEqual(_expenseViewModel.GetCanApprove(), true, "If you set the value to true, it should be true.");
        }

        [TestMethod]
        public void TestSettingCanApproveToFalse()
        {
            _expenseViewModel.SetCanApprove(false);
            Assert.AreEqual(_expenseViewModel.GetCanApprove(), false, "If you set the value to false, it should be false.");
        }

        [TestMethod]
        public void TestSettingCanProcessToTrue()
        {
            _expenseViewModel.SetCanProcess(true);
            Assert.AreEqual(_expenseViewModel.GetCanProcess(), true, "If you set the value to true, it should be true.");
        }

        [TestMethod]
        public void TestSettingCanProcessToFalse()
        {
            _expenseViewModel.SetCanProcess(false);
            Assert.AreEqual(_expenseViewModel.GetCanProcess(), false, "If you set the value to false, it should be false.");
        }
    }
}
