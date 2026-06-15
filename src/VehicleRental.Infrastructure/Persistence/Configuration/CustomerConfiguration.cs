using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleRental.Domain.Entities;

namespace VehicleRental.Infrastructure.Persistence.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.UserId)
                .IsRequired();

            builder.HasIndex(c => c.UserId)
                .IsUnique();

            builder.HasOne<User>()
                .WithOne()
                .HasForeignKey<Customer>(c => c.UserId);

            builder.Property(c => c.DriverLicenseNumber)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(c => c.DriverLicenseExpiryDate)
                .IsRequired();

            builder.Property(c => c.AddressId)
                .IsRequired();

            builder.Property(c => c.TotalRentals)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(c => c.LateReturnsLast12Months)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(c => c.CancellationsLast12Months)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(c => c.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(c => c.UpdatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasIndex(c => c.UserId);
            builder.HasIndex(c => c.AddressId);
        }
    }
}