using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Presenter;
using AirLine_Model;

namespace ConsoleMainRun
{
    public class Program
    {
        static void Main(string[] args)
        {
            // сщздаем предентер, айвью и ай аеропорт
            IView view = new ViewClass();
            IAiroport airport = new Airport();
            PresenterClass presenter = new PresenterClass(view, airport);

            view.SetSettingsForDisplay();
            view.AddFlight();
            view.DisplayFlight();


            Console.ReadLine();
        }
    }
}
