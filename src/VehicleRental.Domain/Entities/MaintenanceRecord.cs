using VehicleRental.Domain.Enums;

namespace VehicleRental.Domain.Entities
{
    internal class MaintenanceRecord
    {
        public long VehicleId { get; set; }
        public long ResponsibleUserId { get; set; }
        public MaintenanceType Type { get; set; }
        public string Description { get; set; } = default!;
        public decimal Cost { get; set; }
        public DateTime ScheduledAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? TechnicianNotes { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool IsCompleted => CompletedAt.HasValue;
    }
}
