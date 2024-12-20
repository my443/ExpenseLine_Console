using ExpenseLine_Console.Data;
using ExpenseLine_Console.App;
using ExpenseLine_Console.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ExpenseLine_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Starts Here!!");

            AppDbContext appDbContext = new AppDbContext();

            GLAccount_Program gLAccount_Program = new GLAccount_Program(appDbContext);

            Console.WriteLine("Program Ends Here!! - Thanks for playing.");
        }
    }
}
