
class Product
{
    private int _id;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(int id, string name, double price, int quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalPrice() => _quantity * _price;

    public override string ToString() => $"{_id}: {_name}";
}