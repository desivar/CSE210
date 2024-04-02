// Customer class
class Customer
{
    public string Name { get; set; }
    public Address CustomerAddress { get; set; }

    public bool LivesInUSA => CustomerAddress.IsUSA;
}
