using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Account.Entities;
using MyStore.Infra.AppConfig;
using MyStore.Infra.Persistence.Mappings;
using System.Diagnostics.CodeAnalysis;

namespace MyStore.Infra.Persistence.Contexts
{
    public partial class MyStoreDataContext : DbContext
    {
        private readonly string _myStoreDbConectionString;

        public MyStoreDataContext()
        {
            _myStoreDbConectionString = new AppConfiguration().ConnectionStringMyStore;
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_myStoreDbConectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}
