using Microsoft.EntityFrameworkCore;

namespace TransportFinder
{
    public class DatabaseConnection : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<TariffTemplateDetail> TariffTemplateDetails { get; set; }

    }
}
