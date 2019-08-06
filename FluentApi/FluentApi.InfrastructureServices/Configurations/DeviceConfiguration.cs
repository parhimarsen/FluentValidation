using FluentApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentApi.InfrastructureServices.Configurations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<InfrastructureDevice>
    {
        public void Configure(EntityTypeBuilder<InfrastructureDevice> builder)
        {
            builder.ToTable("Devices");
            builder.HasKey(_ => _.Id);
        }
    }
}
