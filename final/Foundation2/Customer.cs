/*Customer
* The customer contains a name and an address.
* The name is a string, but the Address is a class.
* The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
*/
class Customer{
    private string _name;
    private Address _address;

        public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }   
    public bool LivesInUSA()
    {
        return Address.LivesInUSA();
    }
}