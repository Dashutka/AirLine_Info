using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Model
{
    public class Airport : IAiroport
    {
        List<Flight> Flights = new List<Flight>(); // remove later


        public void AddFlight(Flight flight) // если ищу, добавляю то нужны аргументы
        {
            Flights.Add(flight);
        }


        public List<Flight> DisplayFlights() // не должно быть аргумента - display all
        {
            return Flights;
        }
    }
}
