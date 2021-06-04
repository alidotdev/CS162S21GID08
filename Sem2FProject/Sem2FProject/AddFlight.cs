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
            DeptCombo.Items.Add(AirportData.GetInstance().Airports);
            ArrivalCombo.Items.Add(AirportData.GetInstance().Airports);
            AirlineCombo.Items.Add(AirlineData.GetInstance().AirlineList);
            for(int i=0;i< AirlineData.GetInstance().AirlineList[0].TotalSeats; i++)
            {
                SeatCombo.Items.Add(i + 1);
            }
            Object[] vs = new Object[2] { "Economy", "Business" };
            ClassCombo.Items.Add(vs);

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            String dept = DeptCombo.SelectedItem.ToString();
            String arr = ArrivalCombo.SelectedItem.ToString();
            Airline airline = (Airline)AirlineCombo.SelectedItem;
            String seat = SeatCombo.SelectedItem.ToString();
            String classType = ClassCombo.SelectedItem.ToString();

        }
    }
}
