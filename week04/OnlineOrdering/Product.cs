class Product {
    string _name;
    string _id;
    float _price;
    int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }


    public float QuantityPrice() // changed this due to not needing arguments since the states of variable stay within this function
    {
        float quantPrice = _price * _quantity;
        return quantPrice;
    }

    // added some getter functions to collect variables so that they are available for reference
    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _id;
    }



}