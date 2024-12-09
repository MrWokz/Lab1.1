using System;

public class Address
{
    private string _index;
    private string _country;
    private string _city;
    private string _street;
    private string _house;
    private string _apartment;

    public string Index
    {
        get { return _index; }
        set { _index = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string House
    {
        get { return _house; }
        set { _house = value; }
    }

    public string Apartment
    {
        get { return _apartment; }
        set { _apartment = value; }
    }
}

class Program
{
    static void Main()
    {
        Address address = new Address();
        address.Index = "01001";
        address.Country = "Ukraine";
        address.City = "Kyiv";
        address.Street = "Khreshchatyk";
        address.House = "1";
        address.Apartment = "10";

        Console.WriteLine("Address:");
        Console.WriteLine($"Index: {address.Index}");
        Console.WriteLine($"Country: {address.Country}");
        Console.WriteLine($"City: {address.City}");
        Console.WriteLine($"Street: {address.Street}");
        Console.WriteLine($"House: {address.House}");
        Console.WriteLine($"Apartment: {address.Apartment}");
    }
}
