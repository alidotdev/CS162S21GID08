using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2FProject
{
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void AddAirportBtn_Click(object sender, EventArgs e)
        {
            new AddAirport().Show();
        }

        private void AddAirlineBtn_Click(object sender, EventArgs e)
        {
            new AddAirline().Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().Show();
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            FlightIdLabel.Text = flight.FlightID;
            DeptCombo.Items.Add(AirportData.GetInstance().Airports);
            ArrivalCombo.Items.Add(AirportData.GetInstance().Airports);
            AirlineCombo.Items.Add(AirlineData.GetInstance().AirlineList);
            for(int i=0;i< 100; i++)
            {
                SeatCombo.Items.Add(i + 1);
            }
            Object[] vs = new Object[2] { "Economy", "Business" };
            ClassCombo.Items.Add(vs);

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Airport dept = (Airport)DeptCombo.SelectedItem;
            Airport arr = (Airport)ArrivalCombo.SelectedItem;
            Airline airline = (Airline)AirlineCombo.SelectedItem;
            String seat = SeatCombo.SelectedItem.ToString();
            String classType = ClassCombo.SelectedItem.ToString();

            Flight flight = new Flight();
            flight.FlightID = FlightIdLabel.Text;
            flight.Departure = dept;
            flight.Destination = arr;
            flight.BookedAirline = airline;
            flight.ReservedSeats = seat;
            flight.ClassType = classType;
            FlightData.GetInstance().AddFlightData(flight);
            this.Hide();
            new AdminHome().Show();
        }
    }
}
