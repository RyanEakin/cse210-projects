using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    
    static void Main(string[] args)
    {   
        // first order
        Address firstLocation = new Address("cherry lane", "Fruitland", "California", "USA");
        Customer firstIdentity = new Customer("bobby",firstLocation);


        Order firstGroceries = CreateOrder(firstIdentity,3);
        Console.WriteLine($"Total: ${firstGroceries.TotalSum().ToString("0.00")}");

        Console.WriteLine("\n");

        // second order
        Address secondLocation = new Address("odensen road", "Glasgow", "South Lanarkshire", "Scotland");
        Customer secondIdentity = new Customer("lassy",secondLocation);


        Order secondGroceries = CreateOrder(secondIdentity,2);
        Console.WriteLine($"Total: ${secondGroceries.TotalSum().ToString("0.00")}");
        

    }

    static Order CreateOrder(Customer person, int products) // added this for simplicity... didn't think about needing this in the design phase
    {
        List<Product> cart = new List<Product>();
        Order receipt = new Order(person,cart);

        List<string> stock = ["barkeep's friend", "Tenderizer", "Gaming Console", "LavaForce: the movie", "pair of Socks", "Toothbrush", "Illegal Illama", "Gun", "Hydrogen Peroxide", "Controller"];
        List<string> id = ["IB8X1","T635F","5PH0U","6RPUV","ZTHLK","J037N", "7IVJ0", "9F1L5", "XV1R4", "1F0SY"];

        Random rnd = new Random();

        float price = (float)(rnd.NextDouble() * (45 - 0.25) + 0.25);
        int quantity = rnd.Next(1,25);
        
        
        Console.WriteLine(receipt.GetShippingLabel());
        for(int item = 0;products > item; item++) {
            int seed = rnd.Next(0,10);
            Product entry = new Product(stock[seed],id[seed],price,quantity);
            cart.Add(entry);
            Console.WriteLine(receipt.GetPackingLabel(entry));
        }
        
        return receipt;
    }
}