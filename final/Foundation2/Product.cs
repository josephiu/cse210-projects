using System.Reflection.Metadata.Ecma335;

public class Product
{
    public string _name;
    public int _productId;
    public double _price;
    public int _quantity ;


    public Product(string Name,int ProductId, double Price, int Quantity)
    {
        _name = Name;
        _productId = ProductId;
        _price = Price;
        _quantity = Quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}

  