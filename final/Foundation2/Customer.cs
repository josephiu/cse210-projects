public class Customer
{
    public string _name;
    public Address _address ;


    public Customer(string Name, Address Address)
    {
        _name = Name;
        _address = Address;

    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }



    public bool IsUSCustomer()
    {
        return _address.IsUSAddress();
    }
}