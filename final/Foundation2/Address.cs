/*Address
* The address contains a string for the street address, the city, state/province, and country.
* The address should have a method that can return whether it is in the USA or not.
* The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
*/
class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
    public Address(string _street, string _city, string _state, string _country){
        Street = _street;
        City = _city;
        State = _state;
        Country = _country;
    }
    public bool LivesInUSA()
    {
        if (Country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        public override string ToString()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}