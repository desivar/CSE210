// Address class
class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsUSA => Country.Equals("USA", StringComparison.OrdinalIgnoreCase);

    public string GetFormattedAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}
