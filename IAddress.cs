namespace WestcoastBank;

public interface IAddress
{
    public string AddressLine { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
}
