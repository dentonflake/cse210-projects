
class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zipCode;
    private string _country;

    public Address(string street, string city, string state, int zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public bool IsInUnitedStates() => _country == "United States";

    public override string ToString() => $"{_street}\n{_city}, {_state} {_zipCode}\n{_country}";
}