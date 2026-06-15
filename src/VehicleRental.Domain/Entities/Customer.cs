namespace VehicleRental.Domain.Entities
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public long UserId { get; set; }
        public string DriverLicenseNumber { get; set; } = default!;
        public DateTime DriverLicenseExpiryDate { get; set; }
        public long  AddressId { get; set; } = default!;
        public int TotalRentals { get; set; }
        public int LateReturnsLast12Months { get; set; }
        public int CancellationsLast12Months { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
