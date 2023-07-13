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
    public string Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
        public override string GetFullDetails()
    {
        return $"{StandardDetails()}\nEvent Type: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {title}\nDate: {date}";
    }
}

//Receptions, which require people to RSVP, or register, beforehand.
class Receptions : Events {
    private string _rsvpEmail;
}
//Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
class OutdoorGatherings : Events {
    private string _weatherForecast;
//Details: For outdoor gatherings, this includes a statement of the weather.
    public OutdoorGatherings(string title, string description, DateTime date, string time, Address address, string weatherForecast)
    : base(title, description, date, time, address)
{
    _weatherForecast = weatherForecast;
}

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }

    public override string ShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {title}\nDate: {date}";
    }
}
//Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.
class Events {
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
//Use an address class for the addresses.
    private Address _address;
    public Events (string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
       _description = description;
       _date = date;
       _time = time; 
       _address = address;
    }
//Standard details - Lists the title, description, date, time, and address.
    public string StandardDetails()
    {
        return $"Title: {Events.title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address}";
    }
//Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    public abstract string FullDetails();
    
//Short description - Lists the type of event, title, and the date.
    public abstract string ShortDescription();
}