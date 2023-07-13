/*Product
Contains the name, product id, price, and quantity of each product.
The price of this product is computed by multiplying the price and the quantity.]
*/
class Product{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public string Name 
    {
        get { return _name; }
        set { _name = value; }
    }
    public string ProductID 
    {
        get { return _productId; }
        set { _productId = value; }
    }
        public decimal Price 
    {
        get { return _price; }
        set { _price = value; }
    }
        public int Quantity 
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductID = productId;
        Price = price;
        Quantity = quantity;
    }
    public decimal TotalPrice()
    {
        return Price * Quantity;
    }
}