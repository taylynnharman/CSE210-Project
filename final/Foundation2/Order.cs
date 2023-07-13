//Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
class Order{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products
    {
        get { return _products; }
        set { _products = value; }
    }
    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }
    public Order(List<Product> _products, Customer _customer)
    {
        Products = _products;
        Customer = _customer;
    }
    private decimal ShippingCost()
    //* This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    {
        if (Customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public decimal TotalCost()
    //The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
    {
        decimal totalCost = 0;

        foreach(Product Product in Products)
        {
            totalCost += Product.TotalPrice(); 
        }
        totalCost += ShippingCost();
        return totalCost;
    }
    public string PackingLabel()
    //A packing label should list the name and product id of each product in the order.
    {
        string packingLabel = "";

        foreach(Product Product in Products)
            packingLabel = $"Name: {Product.Name}, Product ID: {Product.ProductID}";
            return packingLabel;
    }
    public string ShippingLabel()
    //A shipping label should list the name and address of the customer
    {
        string shippingLabel = $"{Customer.Name}\n{Customer.Address}";

        return shippingLabel;
    }
}

