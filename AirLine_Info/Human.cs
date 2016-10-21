using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Info
{
    public enum Sex
    {
        Male,
        Female
    }

    
    abstract public class Human
    {
        private string _firsrtName;
        private string _lastName;
        private DateTime _dateOfBirthday;
        private Sex _sex;
        
        public string FirstName
        {
            get
            {
                return _firsrtName;
            }
            set
            {
                if (FirstName.Length >= 8 || FirstName.Length <= 2)
                {
                    throw new Exception("The name lenght should be from 2 to 8 symbols");                    
                }

            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
            }
        }
        public DateTime DateOfBirthday
        {
            get
            {
                return _dateOfBirthday;
            }
            set
            {
                int age = DateTime.Now.Date.Year - value.Year;
                if (age > 90)
                {
                    throw new Exception("The age should be less than 90 year old");
                }
                if (age <= 0)
                {
                    throw new Exception("The age should be more than 90 year old");
                }
            }
        }

        public Sex Sex
        {
            get
            {
                return _sex;
            }
            set
            {
            }
        }
    }
}
