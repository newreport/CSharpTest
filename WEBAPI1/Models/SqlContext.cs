using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace WEBAPI1.Models
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql(ConfigurationSettings.AppSettings["MysqlConnectionString"], new MySqlServerVersion(new Version(8, 0, 24)));
        }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}
