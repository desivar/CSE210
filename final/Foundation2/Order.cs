// Order class
class Order
{
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }

    public decimal TotalCost
    {
        get
        {
            decimal shippingCost = Customer.LivesInUSA ? 5 : 35;
            decimal productCost = Products.Sum(p => p.TotalCost);
            return productCost + shippingCost;
        }
    }

    public string PackingLabel => string.Join("\n", Products.Select(p => $"{p.Name} (ID: {p.ProductId})"));
    public string ShippingLabel => $"{Customer.Name}\n{Customer.CustomerAddress.GetFormattedAddress()}";
}
