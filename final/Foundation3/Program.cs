//Write a program that creates at least one event of each type and sets all of their values. Then, for event event, call each of the methods to generate the marketing messages and output their results to the screen.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
    }
}
//Lectures, which have a speaker and have a limited capacity.
class Lectures : Events {
    private string _speaker;
    private int _capacity;
}
//Receptions, which require people to RSVP, or register, beforehand.
class Receptions : Events {
    private string _rsvpEmail;
}
//Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
class Outdoor_Gatherings : Events {
    private string _weatherForcast;
//Details: For outdoor gatherings, this includes a statement of the weather.
    public string WeatherStatement()
    {
        return $"Weather: {WeatherForcast}"
    } 
}
//Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
class Events {
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
//Use an address class for the addresses.
    private Address _address;
    public Events (string title, string description, DateTime date, DateTime time, Address address)
    {
        _title = title;
       _description = description;
       _date = date;
       _time = time; 
       _address = address;
    }
//Standard details - Lists the title, description, date, time, and address.
    public StandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }
//Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    public FullDetails()
    {
        return $"Title: {Title} Description: {Description} Date: {Date} Time: {Time}Address: {Address}";
    }
//Short description - Lists the type of event, title, and the date.
    public ShortDescription()
    {
        return $" Title: {_title}, Date: {_date}";
    }
}