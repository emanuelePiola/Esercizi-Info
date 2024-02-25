using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsInterfaccie02
{
    public partial class Form1 : Form
    {
        FlightBookingSystem flightBookingSystem = new FlightBookingSystem();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            IFlight flight = new Flight(txtFlightNumber.Text, txtDestination.Text, dtpDate.Value, Convert.ToDouble(txtPrice.Text));
            flightBookingSystem.BookFlight(flight);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            flightBookingSystem.CancelFlightBooking(txtFlightRemove.Text);
        }

        private void btnTotalRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total revenue is: " + flightBookingSystem.TotalRevenue() + "€");
        }

        private void btnFlightsInformations_Click(object sender, EventArgs e)
        {
            flightBookingSystem.DisplayBookedFlights();
        }
    }
}
