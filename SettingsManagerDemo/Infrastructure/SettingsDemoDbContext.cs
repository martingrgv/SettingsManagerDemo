using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SettingsManagerDemo.Domain.Models;

namespace SettingsManagerDemo.Infrastructure
{
    public sealed class SettingsDemoDbContext : DbContext
    {
        private readonly string _connectionString = "Server=.;Database=SetttingsDemoDb;Integrated Security=True;TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Setting> Settings { get; set; }
    }
}
