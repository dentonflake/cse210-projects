
class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }

        total += _customer.IsInUnitedStates() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.ToString() + "\n";
        }

        return label;
    }

    public string GetShippingLabel() => $"{_customer}\n";
}