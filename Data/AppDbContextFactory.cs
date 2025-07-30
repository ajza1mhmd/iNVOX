using Microsoft.EntityFrameworkCore;

namespace Invox.Data
{
    public class AppDbContextFactory
    {
        private readonly string _connectionString;

        public AppDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public AppDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySQL(_connectionString);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
