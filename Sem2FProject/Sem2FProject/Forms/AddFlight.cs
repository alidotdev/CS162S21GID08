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
            FlightIdLabel.Text = Flight.FlightIDGen();
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
            ComboBoxDataLoad();
        }
        private void ComboBoxDataLoad()
        {
            DeptCombo.Items.Clear();
            ArrivalCombo.Items.Clear();
            AirlineCombo.Items.Clear();
            ClassCombo.Items.Clear();
            List<Airport> arList = AirportData.GetInstance().Airports;
            for (int i = 0; i < arList.Count; i++)
            {
                DeptCombo.Items.Add(arList[i].CityName + ", " + arList[i].CountryName);
                ArrivalCombo.Items.Add(arList[i].CityName + ", " + arList[i].CountryName);
            }

            List<Airline> AL = AirlineData.GetInstance().AirlineList;
            foreach (Airline item in AL)
            {
                AirlineCombo.Items.Add(item.Name);
            }
            
            ClassCombo.Items.Add("Economy");
            ClassCombo.Items.Add("Business");
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            String dept = DeptCombo.Text;
            String arr = ArrivalCombo.Text;
            String airline = AirlineCombo.Text;
            String seat = SeatCombo.Text;
            String classType = ClassCombo.Text;

            Flight flight = new Flight();
            flight.FlightID = FlightIdLabel.Text;
            flight.Departure = dept;
            flight.Destination = arr;
            flight.BookedAirline = airline;
            flight.ReservedSeats = Int32.Parse(seat);
            FlightData.GetInstance().AddFlightData(flight);
            this.Hide();
            new AdminHome().Show();
        }

        private void DeptCombo_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBoxDataLoad();
        }

        private void ArrivalCombo_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBoxDataLoad();
        }

        private void AirlineCombo_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBoxDataLoad();
        }

        private void SeatCombo_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBoxDataLoad();
        }

        private void ClassCombo_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBoxDataLoad();
        }

        private void AirlineCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] ar = AirlineCombo.SelectedItem.ToString().Split(',');
            int num=1;
            for (int i = 0; i < AirlineData.GetInstance().AirlineList.Count; i++)
            {
                if (AirlineData.GetInstance().AirlineList[i].Name == ar[0])
                {
                    num = AirlineData.GetInstance().AirlineList[i].TotalSeats;
                }
            }
            for (int i = 1; i <= num; i++)
            {
                SeatCombo.Items.Add("" + i);
            }
        }
    }
}
