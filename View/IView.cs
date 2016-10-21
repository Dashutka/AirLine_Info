using AirLine_Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
   public interface IView
    {
        // metod not public
        void AddFlight();
        event EventHandler<FlightEventRaise> AddFlightEventRaise;
        event EventHandler DisplayAllFlights;
        void DisplayFlight();
        void PrintFlightsFromList(List<Flight> flights);


    }
}
