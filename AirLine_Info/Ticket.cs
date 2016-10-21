using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Info
{
    public enum ClassFlight
    {
        Business,
        Economy
    }

    class Ticket
    {
        private string _flightNumber;
        private ClassFlight _flightClass;
        private int _seatNumber;


        public Ticket()
        {
            Random r = new Random();


        }
    }
}
