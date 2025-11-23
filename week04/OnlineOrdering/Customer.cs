using System.Net.Sockets;

class Customer
{
    string _name;
    Address _residence;

    public Customer(string name, Address residence)
    {
        _name = name;
        _residence = residence;
    }

    public bool GetLocation()
    // changed the arguments to none because there is no need for one; 
    // changed return type because it needs return a bool... should've noticed earlier in the design phase 
    {
        return _residence.IsUSA();
    }

    // added a getter function to collect customer name so that they are available for reference
    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddress() // changed this to string
    {
        string home = _residence.GetAddress();
        return home;
    }
}