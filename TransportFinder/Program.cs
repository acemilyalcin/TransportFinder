using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
namespace TransportFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DatabaseConnection db = new DatabaseConnection();
            db.Database.EnsureCreated();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
