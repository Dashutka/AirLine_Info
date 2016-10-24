using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLine_Model;

namespace View
{
    public class ViewClass : IView
    {
        public event EventHandler<FlightEventRaise> AddFlightEventRaise = delegate{};
        public event EventHandler DisplayAllFlights = delegate { };

        public void AddFlight()
        {
            Console.WriteLine(@"For add flight, pls enter the following data:");
            Console.Write("1 flight number =>");
            string flightNumber = Console.ReadLine();
            Console.Write("2  City =>");
            string city = Console.ReadLine();
            Console.Write("3 First name =>");
            string firstName = Console.ReadLine();
            Console.Write("4 Last name =>");
            string lastName = Console.ReadLine();

            Flight flight = new Flight(flightNumber, city, firstName, lastName);
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

        public void SetSettingsForDisplay()
        {
            Console.SetWindowSize(160, 50);
            Console.Title = "AirLine information";
            Console.WriteLine("There you can see all information about flights and passengers");
            Console.WriteLine();
        }
    }
}