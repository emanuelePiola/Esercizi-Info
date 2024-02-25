using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsInterfaccie02
{
    internal class Flight : IFlight
    {
        public string FlightNumber { get; }
        public string Destination { get; }
        public DateTime Date { get; }
        public double Price { get; }

        public Flight(string flightNumber, string destination, DateTime date, double price)
        {
            FlightNumber = flightNumber;
            Destination = destination;
            Date = date;
            Price = price;
        }
    }
}
