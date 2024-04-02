using System;
using System.Collections.Generic;

// Product class
class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal TotalCost => Price * Quantity;
}
