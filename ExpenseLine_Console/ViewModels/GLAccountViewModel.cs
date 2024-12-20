using ExpenseLine_Console.Data;
using ExpenseLine_Console.Models;

namespace ExpenseLine_Console.ViewModels
{
    public class GLAccountViewModel
    {
        public List<GLAccount> GLAccounts { get; set; } = new List<GLAccount>();

        public GLAccountViewModel(AppDbContext appDbContext) { 
            GLAccounts = appDbContext.GLAccounts.ToList();
        }
    }
}
