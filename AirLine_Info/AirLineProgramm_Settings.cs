using System;

namespace AirLine_Info
{
    public class AirLineProgramm_Settings
    {
        public void SetSettingsForDisplay()
        {
            Console.SetWindowSize(160, 50);
            Console.Title = "AirLine information";
            Console.WriteLine("There you can see all information about flights and passengers");
        }
        public void SelectSearchOptions()
        {
            Console.WriteLine("Please select options for select");
        }

        public void SetMenuMode()
        {
            Console.WriteLine("");
        }
    }
}
