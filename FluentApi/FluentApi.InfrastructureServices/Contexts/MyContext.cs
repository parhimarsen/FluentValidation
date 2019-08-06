using FluentApi.Infrastructure.Models;
using FluentApi.InfrastructureServices.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FluentApi.InfrastructureServices.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public virtual DbSet<InfrastructureUser> Users { get; set; }
        public virtual DbSet<InfrastructureDevice> Devices { get; set; }
        public virtual DbSet<InfrastructureQuery> Queries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder.ApplyConfiguration(new UserConfiguration()));
            base.OnModelCreating(modelBuilder.ApplyConfiguration(new DeviceConfiguration()));
            base.OnModelCreating(modelBuilder.ApplyConfiguration(new QueryConfiguration()));
        }
    }
}
