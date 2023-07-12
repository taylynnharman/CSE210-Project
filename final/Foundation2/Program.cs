using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
    }
}
/*Product
* Contains the name, product id, price, and quantity of each product.
* The price of this product is computed by multiplying the price and the quantity.]
* Why can't I use the format private string _name { get;,set; } like in foundations 1?
*/
class Product{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

}
class Customer{}
class Address{}

/* Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
* The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
* This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
* A packing label should list the name and product id of each product in the order.
* A shipping label should list the name and address of the customer
*/
class Order{
    private List<Product> _products;
    private string _customer;

    public TotalCost()
    {
        float totalCost = 0;
    }
}

/*
Program Specification

Product
* Contains the name, product id, price, and quantity of each product.
* The price of this product is computed by multiplying the price and the quantity.
Customer
* The customer contains a name and an address.
* The name is a string, but the Address is a class.
* The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
Address
* The address contains a string for the street address, the city, state/province, and country.
* The address should have a method that can return whether it is in the USA or not.
* The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
Other considerations
Make sure that all member variables are private and getters, setters, and constructors are created as needed.
Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.

*/