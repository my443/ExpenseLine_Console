using ExpenseLine_Console.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseLine_Console.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() { } // This one
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Define the SQLite connection string (replace with your desired file path)
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\jvand\\source\\repos\\ExpenseLine_Console\\ExpenseDatabase.db3");
        }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Approval> Approvals{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<ExpenseDetail> ExpenseDetails{ get; set; }
        public DbSet<ExpenseStatus> ExpenseStatus{ get; set; }
        public DbSet<FileType> FileTypes{ get; set; }
        public DbSet<GLAccount> GLAccounts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
