using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleRental.Domain.Entities;

namespace VehicleRental.Infrastructure.Persistence.Configuration
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rentals");

            builder.HasKey(r => r.RentalId);

            builder.Property(r => r.CustomerId)
                .IsRequired();

            builder.HasOne<Customer>()
                .WithMany()
                .HasForeignKey(r => r.CustomerId);

            builder.Property(r => r.VehicleId)
                .IsRequired();

            builder.HasOne<Vehicle>()
                .WithMany()
                .HasForeignKey(r => r.VehicleId);

            builder.Property(r => r.StartPeriod)
                .IsRequired();

            builder.Property(r => r.FinalPeriod)
                .IsRequired();

            builder.Property(r => r.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(r => r.ReturnMileage)
                .IsRequired()
                .HasPrecision(10, 2);

            builder.Property(r => r.CancellationReason)
                .HasMaxLength(500);

            builder.Property(r => r.ActualReturnAt);

            builder.Property(r => r.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(r => r.UpdatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasIndex(r => r.CustomerId);
            builder.HasIndex(r => r.VehicleId);
            builder.HasIndex(r => r.Status);
        }
    }
}