using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Info
{
    public enum FlightCondition
    {
        Arrival,
        Departure
    }

    public class Flight
    {
        public FlightCondition FlightCondition;
        public DateTime At;
        private string FlightNumber;
        public string City;
        public int Terminal;
        public string Gate;
        public FlightStatus FlightStatus;
        // public List<Passenger> passengers = new List<Passenger>();

        public Flight() // random add
        {
            Random r = new Random(DateTime.Now.Minute);
            DateTime now = DateTime.Now;
            string[] city = new string[] { "Kharkiv", "Kiev", "Lviv", "Paris", "Oslo", "Munich" };
            string[] gates = new string[] { "A", "B", "C", "D", "F", "G" };
            DateTime currentDate = DateTime.Now;
            string year = currentDate.Year.ToString();
            string day = currentDate.DayOfYear.ToString();
            string hour = currentDate.Hour.ToString();
            string min = currentDate.Minute.ToString();

            this.FlightCondition = (FlightCondition)r.Next(2);
            this.At = now.AddDays(r.Next(30)).AddMinutes(r.Next(1440));
            this.City = city[r.Next(0, city.Length - 1)];
            this.FlightNumber = (this.City.Substring(0, 2) + year + day + hour + min);
            this.Terminal = r.Next(1, 23);
            this.Gate = gates[r.Next(0, gates.Length - 1)];
            this.FlightStatus = (FlightStatus)r.Next(0, 8);
        }

        public Flight(string flightNumber, string city)
        {
            FlightNumber = flightNumber;
            City = city;
        }

    }

    //public override string ToString()
    //{
    //    return $"{At,20} {FlightNumber,20} {City,20}  {Terminal,10} {Gate,10} {FlightStatus,20}";
    //}        
}