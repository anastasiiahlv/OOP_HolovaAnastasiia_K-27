using System;
using System.Collections.Generic;
using System.Collections.Specialized;

class Task6_2_Program
{
    static void Main()
    {
        BookingFacade facade = new BookingFacade();

        facade.FullPackageBooking();
        Console.WriteLine();
        facade.FullPackageCansellation();

        Console.ReadKey();
    }
}

// Subsystem A
public class FlightBookingSystem
{
    public void Time()
    {
        Random random = new Random();

        int hours = random.Next(0, 24);
        int minutes = random.Next(0, 60);

        DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0, 0);

        Console.WriteLine(randomTime.ToString("HH:mm"));
    }

    public void GetInfo()
    {
        Console.WriteLine("The airline ticket is booked.");
        Console.Write("Departure time: ");
        Time();
    }

    public void TicketReturn()
    {
        Console.WriteLine("The return of the plane ticket was successful.");
    }
}

// Subsystem B
public class HotelBookingSystem
{
    public void GetInfo()
    {
        Console.WriteLine("Hotel is booked for 7 days.");
    }

    public void CancellationOfHotelReservation()
    {
        Console.WriteLine("The hotel cancellation was successful.");
    }
}

// Facade
public class BookingFacade
{
    private FlightBookingSystem _flightBooking;
    private HotelBookingSystem _hotelBooking;

    public BookingFacade()
    {
        _flightBooking = new FlightBookingSystem();
        _hotelBooking = new HotelBookingSystem();
    }

    public void FullPackageBooking()
    {
        Console.WriteLine("Booking a full package:");

        Console.WriteLine("----------------------------");
        _flightBooking.GetInfo();
        _hotelBooking.GetInfo();
        Console.WriteLine("----------------------------");

        Console.WriteLine("The full package has been booked.");
    }

    public void FullPackageCansellation()
    {
        Console.WriteLine("Refusal of the full package:");

        Console.WriteLine("----------------------------");
        _flightBooking.TicketReturn();
        _hotelBooking.CancellationOfHotelReservation();
        Console.WriteLine("----------------------------");

        Console.WriteLine("The full package was rejected.");
    }
}


