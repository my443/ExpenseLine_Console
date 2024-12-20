using ExpenseLine_Console.Data;
using ExpenseLine_Console.Models;
using ExpenseLine_Console.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseLine_Console_Test
{
    [TestClass]
    public sealed class AccountViewModelTest
    {
        private GLAccountViewModel _glAccountViewModel;
        private AppDbContext _appDbContext;

        [TestInitialize]
        public void Setup()
        {
            _appDbContext = new AppDbContext();
            _glAccountViewModel = new GLAccountViewModel(_appDbContext);
        }

        [TestMethod]
        public void AddingItemTest()
        {
            // Create a new GLAccount
            GLAccountViewModel gLAccount = new GLAccountViewModel(_appDbContext);
            gLAccount.AddGLAccount("This is my testing account", "1234Test");
            
            // See if it exists in the database
            GLAccount retrievedAccount = _appDbContext.GLAccounts.FirstOrDefault(a => a.AccountNumber == "1234Test");            
            Assert.IsNotNull(retrievedAccount);

            // Remove the account after you have done the test.
            _appDbContext.Remove(retrievedAccount);                 
            _appDbContext.SaveChanges();
        }

        [TestMethod]
        public void AddingItemWithNoAccountNumber()
        {
            // Create a new GLAccount
            GLAccountViewModel gLAccount = new GLAccountViewModel(_appDbContext);
            gLAccount.AddGLAccount();

            // See if it exists in the database, but there is no number.
            GLAccount retrievedAccount = _appDbContext.GLAccounts.FirstOrDefault(a => a.AccountNumber == "");
            Assert.AreEqual(retrievedAccount.Name , "New Account");

            // Remove the account after you have done the test.
            _appDbContext.Remove(retrievedAccount);
            _appDbContext.SaveChanges();
        }


    }
}
