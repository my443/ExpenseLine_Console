using ExpenseLine_Console.Data;
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

            // register appdbcontext for dependency injection
            var servicecollection = new ServiceCollection();

            // register dbcontext with di
            servicecollection.<AppDbContext>(options =>
                options.usesqlite("c:\\users\\jvand\\source\\repos\\expenseline_console\\expensedatabase.db3"));

            // build the service provider
            var serviceprovider = servicecollection.buildserviceprovider();



            Console.WriteLine("Program Ends Here!! - Thanks for playing.");
        }
    }
}
