using System.Runtime.CompilerServices;

class Order
{
    Customer _person;
    List<Product> _cart;

    public Order(Customer person, List<Product> cart)
    {
        
        _person = person;
        _cart = cart;
    }

    public string GetPackingLabel(Product item)
    {
        string strought = $"Product Name: {item.GetProductName()} \nProduct ID:{item.GetProductID()}";
        return strought;
    }
    public string GetShippingLabel() // changed this to no arguments due to it being more appropriate
    {
        string strought = $"Customer Name: {_person.GetCustomerName()} \nCustomer Address: {_person.GetCustomerAddress()}";
        return strought;       
    }

    public float TotalSum()
    {
        float totality = 0;
        int shippingCosts = 35;

        foreach(Product item in _cart)
        {
            totality += item.QuantityPrice();
        }
        
        if (_person.GetLocation() == true)
        {
            shippingCosts = 5;
        }

        totality += shippingCosts;

        return totality;
    }
}