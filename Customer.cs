namespace WestcoastBank;

public class Customer
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public List<Address>? Addresses { get; set; }
}
