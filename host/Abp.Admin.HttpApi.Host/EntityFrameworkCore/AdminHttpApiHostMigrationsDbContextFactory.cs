using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.Admin.EntityFrameworkCore
{
    public class AdminHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AdminHttpApiHostMigrationsDbContext>
    {
        public AdminHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AdminHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Admin"));

            return new AdminHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
