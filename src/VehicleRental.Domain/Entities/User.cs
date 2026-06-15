using VehicleRental.Domain.Enums;

namespace VehicleRental.Domain.Entities
{
    public class User
    {
        public long UserId { get; private set; }
        public string Email { get; private set; } = default!;
        public string PasswordHash { get; private set; } = default!;
        public string FirstName { get; private set; } = default!;
        public string LastName { get; private set; } = default!;
        public DateTime DateOfBirth { get; private set; }
        public string PhoneNumber { get; private set; } = default!;
        public UserRole Role { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
