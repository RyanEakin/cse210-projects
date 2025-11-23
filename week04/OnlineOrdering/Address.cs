using System.Collections.Concurrent;

class Address
{
    string _street;
    string _city;
    string _state;
    string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city   = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        string addressString = $"{_street},{_city},{_state},{_country}";
        return addressString;
    }

    public bool IsUSA()
    {
        bool USA = false;
        if (_country == "USA")
        {
            USA = true;
        }
        return USA;
    }
}
