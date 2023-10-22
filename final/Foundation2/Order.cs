public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0.0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        total += (_customer.IsUSCustomer() ? 5.0 : 35.0);
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"Product: {product._name}, Product ID: {product._productId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer Name: {_customer._name}\nCustomer Address: {_customer._address.GetAddressDetails()}";
    }
}
