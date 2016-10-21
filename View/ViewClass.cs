using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine_Info;

namespace View
{
    public class ViewClass : IView
    {
        public event EventHandler<FlightEventRaise> AddFlightEventRaise = delegate{};
        public event EventHandler DisplayAllFlights = delegate { };

        public void AddFlight()
        {
            Console.WriteLine(@"For add flight, pls enter data:
1) flight number
2) City");
            Console.Write("1");
            string flightNumber = Console.ReadLine();
            Console.Write("2");
            string city = Console.ReadLine();
            Flight flight = new Flight(flightNumber, city);
            AddFlightEventRaise(this, new FlightEventRaise(flight));
        }

        public void DisplayFlight()
        {
            Console.WriteLine("I will show all flights");
            DisplayAllFlights(this, new EventArgs());
        }

        public void PrintFlightsFromList(List<Flight> flights)
        {
            foreach (var item in flights)
            {
                Console.WriteLine(item);
            }
        }
    }
}