using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Model
{
    public interface IAiroport
    {
        void AddFlight(Flight flight);
        List<Flight> DisplayFlights();
        
    }
}
