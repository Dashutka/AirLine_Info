using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Info
{

    public class Passenger : Human
    {

        object Passport;

        public Passenger()
        {
            Random r = new Random(DateTime.Now.Minute);
            string[] _firstName = new string[] { "Anna", "Petya", "Larisa", "Yura", "Nastya" };
            string[] _lastName = new string[] { "LastName1", "LastName2", "LastName3" };
            DateTime _dayOfBirth = DateTime.Now;
            this.FirstName = _firstName[r.Next(0, _firstName.Length - 1)];
            this.LastName = _lastName[r.Next(0, _lastName.Length - 1)]; ;
            this.DateOfBirthday = _dayOfBirth.AddDays(r.Next(-10000, 0));
            this.Sex = (Sex)r.Next(0, 1);
        }
    }
}
