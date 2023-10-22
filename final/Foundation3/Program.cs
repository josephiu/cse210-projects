using System;

class Program
{
    static void Main(string[] args)
    {


        Address address1 = new Address("63 Abu hull St", "Abu Dhabi city", "Abu Dhabi", "United Arab Emirate"); //street, city, state, country
        Address address2 = new Address("68 Al Fatima St", "Jumairah", "Dubai", "United Arab Emirate"); //street, city, state, country

//event for lectureing
        Event event1 = new Event("Lecture Event", "Medical Training lecture", "2023-10-28", "08:00 AM", address1); //tittle, description, date, time, address
        Lecture lecture1 = new Lecture("Lecture Event", "Medical Training lecture", "2023-10-28", "08:00 AM", address1, "Joseph israel", 36);//tittle, description, date, time, address, speaker, capacity


// Event for reception
        Event event2 = new Event("Reception Event", "Marriage reception", "2023-10-26", "3:00 PM", address2);
        Reception reception1 = new Reception("Reception Event", "Marriage reception", "2023-10-26", "3:00 PM", address2, "iu.joseph37@gmail.com");

// Event for outdoor
        Event event3 = new Event("Outdoor Gathering", "Fitness Walk out", "2023-10-25", "12:00 PM", address1);
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Outdoor Gathering", "fitness Walk out", "2023-10-25", "12:00 PM", address1, "Humid");

        Event[] events = { event1, lecture1, event2, reception1, event3, outdoorGathering1 };

        foreach (Event even in events)
        {
            Console.WriteLine(even.GenerateMarketingMessage() + "\n");
        }
    }
}