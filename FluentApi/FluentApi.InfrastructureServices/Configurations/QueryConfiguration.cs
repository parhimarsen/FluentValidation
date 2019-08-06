using FluentApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentApi.InfrastructureServices.Configurations
{
    public class QueryConfiguration : IEntityTypeConfiguration<InfrastructureQuery>
    {
        public void Configure(EntityTypeBuilder<InfrastructureQuery> builder)
        {
            builder.ToTable("Querys");
            builder.HasKey(_ => _.Id);
        }
    }
}
