using VehicleRental.Domain.Enums;

namespace VehicleRental.Domain.Entities
{
    public class Rental
    {
        public long RentalId { get; set; }
        public long CustomerId { get; set; }
        public long VehicleId { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime FinalPeriod { get; set; }
        public RentalStatus Status { get; set; }
        public decimal ReturnMileage { get; set; }
        public string? CancellationReason { get; set; }
        public DateTime? ActualReturnAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
