using FluentApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentApi.InfrastructureServices.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<InfrastructureUser>
    {
        public void Configure(EntityTypeBuilder<InfrastructureUser> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(_ => _.Id);
        }
    }
}
