public class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;




    public Address(string Street, string City, string State, string Country)
    {
        _street = Street;
        _city = City;
        _state = State;
        _country = Country;
    }


    public string GetStreet()
    {
        return _street;
    }
    
    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }



    public bool IsUSAddress()
    {
        return _country == "USA";
    }

    public string GetAddressDetails()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}