using VehicleRental.Domain.Enums;

namespace VehicleRental.Domain.Entities
{
    public class Vehicle
    {
        public long VehicleId { get; private set; }
        //^[A-Z0-9- ]{2,15}$
        public string LicensePlate { get; private set; } = default!;
        public string Model { get; private set; } = default!;
        public int Year { get; private set; }
        public string Color { get; private set; } = default!;
        public VehicleCategory Category { get; private set; }
        public FuelType FuelType { get; private set; }
        public VehicleStatus Status { get; private set; }
        public decimal DailyValue { get; set; }
        public decimal CurrentMileage { get; private set; }
        public string? ImageUrl { get; private set; }
        public string? Notes { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
