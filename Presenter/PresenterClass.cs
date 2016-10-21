using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using AirLine_Info;

namespace Presenter
{
    public class PresenterClass 
    {        
        IView _view;
        IAiroport _airoport;
        public PresenterClass(IView view, IAiroport airoport)
        {
            _view = view;
            _airoport = airoport;
            _view.AddFlightEventRaise += OnAddFlightEventRaise;// обработчик
            _view.DisplayAllFlights += OnDisplayAllFlights;

        }

        private void OnDisplayAllFlights(object sender, EventArgs e)
        {
            _airoport.DisplayFlights();
            _view.PrintFlightsFromList(_airoport.DisplayFlights());
        }

        private void OnAddFlightEventRaise(object sender, FlightEventRaise e) // flight exist
        {
            _airoport.AddFlight(e.Flight);
        }

    }
}
