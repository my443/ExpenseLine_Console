using ExpenseLine_Console.Data;
using ExpenseLine_Console.Models;
using System;
using System.Security.Principal;

namespace ExpenseLine_Console.ViewModels
{
    public class GLAccountViewModel
    {
        public List<GLAccount> GLAccounts { get; set; } = new List<GLAccount>();
        private AppDbContext _appDBContext;

        public GLAccountViewModel(AppDbContext appDbContext)
        {
            _appDBContext = appDbContext;
            GetGLAccountList();
        }

        public void GetGLAccountList()
        {
            GLAccounts = _appDBContext.GLAccounts.ToList();
        }

        public void AddGLAccount(string Name="New Account", string AccountNumber="")
        {
            GLAccount gLAccount = new GLAccount();

            gLAccount.Name = Name;
            gLAccount.AccountNumber = AccountNumber;
            
            _appDBContext.Add(gLAccount);
            _appDBContext.SaveChanges();
        }

        private void DeleteGLAccount(int id)
        {
            GLAccount gLAccount = _appDBContext.GLAccounts.Find(id);
            if (gLAccount != null)
            {
                _appDBContext.Remove(gLAccount);
                _appDBContext.SaveChanges();
            }
        }

        private void UpdateGLAccount(int id, string Name, string AccountNumber)
        {
            GLAccount gLAccount = _appDBContext.GLAccounts.Find(id);
            if (gLAccount != null)
            {
                gLAccount.Name = Name;
                gLAccount.AccountNumber = AccountNumber;
                _appDBContext.Update(gLAccount);
                _appDBContext.SaveChanges();
            }
        }
    }
}
