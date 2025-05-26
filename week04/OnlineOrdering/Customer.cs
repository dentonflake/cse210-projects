
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUnitedStates() => _address.IsInUnitedStates();

    public override string ToString() => $"{_name}\n{_address.ToString()}";
}