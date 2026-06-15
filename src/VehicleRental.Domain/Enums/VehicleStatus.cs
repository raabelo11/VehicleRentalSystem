namespace VehicleRental.Domain.Enums
{
    public enum VehicleStatus
    {
        Available = 1,
        Rented = 2,
        Maintenance = 3,
        Inactive = 4
    }

    public enum VehicleCategory
    {
        Economy = 1,
        Standard = 2,
        SUV = 3,
        Luxury = 4,
        Van = 5
    }

    public enum FuelType
    {
        Gasoline = 1,
        Diesel = 2,
        Electric = 3,
        Hybrid = 4,
        Flex = 5
    }

    public enum RentalStatus
    {
        Reserved = 1,
        Confirmed = 2,
        Active = 3,
        Completed = 4,
        Cancelled = 5
    }

    public enum UserRole
    {
        Customer = 1,
        Admin = 2
    }
}
