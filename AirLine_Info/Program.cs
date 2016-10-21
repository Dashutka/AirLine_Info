using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            AirLineProgramm_Settings settings = new AirLineProgramm_Settings();
            settings.SetSettingsForDisplay();

            Flight flights = new Flight();
        }
    }
}
