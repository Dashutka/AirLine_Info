using AirLine_Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
   public class FlightEventRaise : EventArgs
    {
        public Flight Flight { get; set; }
        public FlightEventRaise(Flight flight)
        {
            Flight = flight;
        }
    }
}
