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
            if (txtFlightNumber.Text != "" && txtDestination.Text != "" && Convert.ToDouble(txtPrice.Text) >= 0) 
            {
                IFlight flight = new Flight(txtFlightNumber.Text, txtDestination.Text, dtpDate.Value, Convert.ToDouble(txtPrice.Text));
                flightBookingSystem.BookFlight(flight);
            }
            else
            {
                MessageBox.Show("Prenotation data no complete", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(flightBookingSystem.flightExist(txtFlightRemove.Text))
            {
                flightBookingSystem.CancelFlightBooking(txtFlightRemove.Text);
            }
            else
            {
                MessageBox.Show("You have to put in input the number of the flight to remove, it must exist","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
