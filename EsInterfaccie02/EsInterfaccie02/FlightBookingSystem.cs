using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsInterfaccie02
{
    internal class FlightBookingSystem
    {
        private List<IFlight> prenotations;

        public FlightBookingSystem()
        {
            prenotations=new List<IFlight>();
        }

        public void BookFlight(IFlight flight)
        {
            prenotations.Add(flight);
        }

        public void CancelFlightBooking(string flightNumber)
        {
            foreach(var flight in prenotations)
            {
                if(flight.FlightNumber == flightNumber)
                {
                    prenotations.Remove(flight);
                    break;
                }
            }
        }

        public double TotalRevenue()
        {
            double total = 0;

            foreach(var flight in prenotations)
            {
                total += flight.Price;
            }

            return total;
        }

        public void DisplayBookedFlights()
        {
            string display = "Prenotations:\n\n";

            foreach(var flight in prenotations)
            {
                display+=$"{flight.FlightNumber}\n" +
                    $"Flight for {flight.Destination} in date: {flight.Date.ToShortDateString()}\n" +
                    $"Price: {flight.Price}€\n\n";
            }

            MessageBox.Show(display);
        }
    }
}
