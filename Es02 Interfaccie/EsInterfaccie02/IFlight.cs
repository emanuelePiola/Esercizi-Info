using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsInterfaccie02
{
    internal interface IFlight
    {
        string FlightNumber { get; }
        string Destination { get; }
        DateTime Date { get; }
        double Price { get; }
    }
}
