using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Info
{
    class AirportGenerator
    {
        
        List<Passenger> PassengerForConcreteFlight = new List<Passenger>();
        List<Ticket> TicketForOnePassenger = new List<Ticket>();
        private int NewFlightId = 1;

        public List<Flight> Generate()
        {
            List<Flight> FlightConcrete = new List<Flight>();

            for (int i = 0; i < 20; i++)
            {
                FlightConcrete.Add(new Flight());
            }

            // generate pessa
            //...


            //foreach (var flight in FlightConcrete)
            //{
            //    foreach(var ticket in flight.Tickets)
            //    {
            //        ...
            //        ticket.Passanger = ...
            //    }
            //}


            return FlightConcrete;

        }

    }
}
