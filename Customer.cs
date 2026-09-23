namespace WestcoastBank;

public class Customer
: ICustomer
{
    public Customer(string id)
    {
        FindCustomer(id);
    }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public List<Address>? Addresses { get; set; }
    private void FindCustomer(string id)
    {
        FirstName = "Alfred";
        LastName = "Wendt";
        Email = "affewendt@gmail.com";
        PhoneNumber = "0760869095";
    }
}
