using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleRental.Domain.Entities;

namespace VehicleRental.Infrastructure.Persistence.Configuration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");
            builder.HasKey(v => v.VehicleId);

            builder.Property(v => v.LicensePlate)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(v => v.Model)
                .IsRequired()
                .HasMaxLength(70);

            builder.Property(v => v.Year)
                .IsRequired();

            builder.Property(v => v.Color)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(v => v.Category)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(v => v.FuelType)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(v => v.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(v => v.DailyValue)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(v => v.CurrentMileage)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(v => v.ImageUrl)
                .HasMaxLength(500);

            builder.Property(v => v.Notes)
                .HasMaxLength(500);

            builder.Property(v => v.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(v => v.UpdatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
