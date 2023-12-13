using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA
        addresses[0] = new Address("234", "Richmond", "Virginia", "USA");
        customers[0] =  new Customer("Mr. Jacob Thomas",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Nautica Blue Oceans","P042",16.99f,2));
        productsLists[0].Add(new Product("Sky Ryder x -51 Helicopter","G438",21.05f ,1));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("1435", "George Town", "Grand Cayman ", "Cayman Islands");
        customers[1] =  new Customer("Arturo Jones",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Izod Mens Log Sleeve 2 pc Pant Pajama Sset", "S445",42.00f,2));
        productsLists[1].Add(new Product("St Jones Bay Mens Acton Flat Heel Chukka Boots","B002",21.99f,1));
        productsLists[1].Add(new Product("PGA Tour Mens Polo Shirt","P436",28.56f,2));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N°{i+1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{orders[i].GetPackingLabel()}"); 
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}